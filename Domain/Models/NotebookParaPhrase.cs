using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademicWritingUtility.Domain.Models
{
    public class NotebookParaPhrase : ArticleNotebookRelated
    {
        public Guid ParaPhraseId { get; private set; }

        public ParaPhrase ParaPhrase { get; private set; }

        internal static NotebookParaPhrase New(Guid id, Guid articleNotebookId, Guid paraPhraseId)
        {
            return new NotebookParaPhrase(id, articleNotebookId, paraPhraseId);
        }
        internal static NotebookParaPhrase New(Guid articleNotebookId, Guid paraPhraseId)
        {
            return new NotebookParaPhrase(articleNotebookId, paraPhraseId);
        }

        public NotebookParaPhrase() : base() { }
        internal NotebookParaPhrase(Guid id, Guid articleNotebookId, Guid paraPhraseId) 
            : base (id, articleNotebookId)
        {
            ParaPhraseId = paraPhraseId;
        }
        internal NotebookParaPhrase(Guid articleNotebookId, Guid paraPhraseId)
            : base(articleNotebookId)
        {
            ParaPhraseId = paraPhraseId;
        }
    }
}
