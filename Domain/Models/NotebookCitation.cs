using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademicWritingUtility.Domain.Models
{
    public class NotebookCitation : ArticleNotebookRelated
    {
        public Guid CitationId { get; private set; }

        internal static NotebookCitation New(Guid id, Guid articleNotebookId, Guid citationId)
        {
            return new NotebookCitation(id, articleNotebookId, citationId);
        }
        internal static NotebookCitation New(Guid articleNotebookId, Guid citationId)
        {
            return new NotebookCitation(articleNotebookId, citationId);
        }

        public NotebookCitation() : base() { }
        private NotebookCitation(Guid id, Guid articleNotebookId, Guid citationId) : base(id, articleNotebookId)
        {
            CitationId = citationId;
        }
        private NotebookCitation(Guid articleNotebookId, Guid citationId) : base(articleNotebookId)
        {
            CitationId = citationId;
        }
    }
}
