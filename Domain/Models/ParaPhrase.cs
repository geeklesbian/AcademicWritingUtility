using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademicWritingUtility.Domain.Models
{
    public class ParaPhrase : BaseClass
    {
        public Guid CitationId { get; private set; }
        public string PageNumber { get; private set; }
        public Guid VersionId { get; private set; }
        public int Order { get; private set; }
        public string Phrase { get; private set; }

        public Citation Citation { get; private set; }
        public PaperVersion PaperVersion { get; private set; }


        public static ParaPhrase New(Guid id, Guid citationId, string pageNumber, Guid versionId, int order, string phrase)
        {
            return new ParaPhrase(id, citationId, pageNumber, versionId, order, phrase);
        }
        public static ParaPhrase New(Guid citationId, string pageNumber, Guid versionId, int order, string phrase)
        {
            return new ParaPhrase(citationId, pageNumber, versionId, order, phrase);
        }

        public ParaPhrase() : base() { }

        internal ParaPhrase(Guid? citationId, string pageNumber, Guid versionId, int order, string phrase) : base()
        {
            SetValues(citationId, pageNumber, versionId, order, phrase);
        }
        internal ParaPhrase(Guid id, Guid? citationId, string pageNumber, Guid versionId, int order, string phrase) : base(id)
        {
            SetValues(citationId, pageNumber, versionId, order, phrase);
        }
        private void SetValues(Guid? citationId, string pageNumber, Guid versionId, int order, string phrase)
        {
            CitationId = citationId != null ? (Guid)citationId : Guid.Empty;
            PageNumber = pageNumber;
            VersionId = versionId;
            Order = order;
            Phrase = phrase;
        }
    }
}
