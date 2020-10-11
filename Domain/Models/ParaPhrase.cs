using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademicWritingUtility.Domain.Models
{
    public class ParaPhrase : BaseClass
    {
        public Guid VersionId { get; private set; }
        public int Order { get; private set; }
        public string Phrase { get; private set; }
        public Guid CitationId { get; private set; }


        public ParaPhrase() : base() { }
        public ParaPhrase(Guid versionId, int order, string phrase, Guid? citationId) : base()
        {
            SetValues(versionId, order, phrase, citationId);
        }
        public ParaPhrase(Guid id, Guid versionId, int order, string phrase, Guid? citationId) : base(id)
        {
            SetValues(versionId, order, phrase, citationId);
        }
        private void SetValues(Guid versionId, int order, string phrase, Guid? citationId)
        {
            VersionId = versionId;
            Order = order;
            Phrase = phrase;
            CitationId = citationId != null ? (Guid)citationId : Guid.Empty;
        }
    }
}
