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
        public int Order { get; private set; }
        public string Phrase { get; private set; }

        public List<NotebookParaPhrase> NotebookParaPhrases { get; set; } = new List<NotebookParaPhrase>();
        public List<VersionParaPhrase> VersionParaPhrases { get; set; } = new List<VersionParaPhrase>();

        public Citation Citation { get; private set; }

        internal static ParaPhrase New(Guid id, Guid citationId, string pageNumber,  int order, string phrase)
        {
            return new ParaPhrase(id, citationId, pageNumber, order, phrase);
        }
        internal static ParaPhrase New(Guid citationId, string pageNumber,  int order, string phrase)
        {
            return new ParaPhrase(citationId, pageNumber,  order, phrase);
        }

        public ParaPhrase() : base() { }

        internal ParaPhrase(Guid? citationId, string pageNumber, int order, string phrase) : base()
        {
            SetValues(citationId, pageNumber, order, phrase);
        }
        internal ParaPhrase(Guid id, Guid? citationId, string pageNumber,  int order, string phrase) : base(id)
        {
            SetValues(citationId, pageNumber, order, phrase);
        }
        private void SetValues(Guid? citationId, string pageNumber,  int order, string phrase)
        {
            CitationId = citationId != null ? (Guid)citationId : Guid.Empty;
            PageNumber = pageNumber;
            Order = order;
            Phrase = phrase;
        }
    }
}
