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

        public CitationResearcher() : base() { }
        public CitationResearcher(Guid id, Guid citationId, Guid researcherId) : base(id)
        {
            SetValues(citationId, researcherId);
        }
        public CitationResearcher(Guid citationId, Guid researcherId) : base()
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
