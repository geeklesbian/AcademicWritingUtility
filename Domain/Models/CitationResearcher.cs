using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademicWritingUtility.Domain.Models
{
    public class CitationResearcher : BaseClass
    {
        public Guid CitationId { get; private set; }
        public Guid ResearcherId { get; private set; }

        public Citation Citation { get; private set; }
        public Researcher Researcher { get; private set; }


        internal static CitationResearcher New(Guid id, Guid citationId, Guid researcherId)
        {
            return new CitationResearcher(id, citationId, researcherId);
        }
        internal static CitationResearcher New(Guid citationid, Guid researcherid)
        {
            return new CitationResearcher(citationid, researcherid);
        }
        public CitationResearcher() : base() { }
        internal CitationResearcher(Guid id, Guid citationId, Guid researcherId) : base(id)
        {
            SetValues(citationId, researcherId);
        }
        internal CitationResearcher(Guid citationId, Guid researcherId) : base()
        {
            SetValues(citationId, researcherId);
        }
        private void SetValues(Guid citationId, Guid researcherId)
        {
            CitationId = citationId;
            ResearcherId = researcherId;
        }
    }
}
