using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademicWritingUtility.Domain.Models
{
    public class NotebookExternalCitation : ArticleNotebookRelated
    {
        public Guid ExternalCitationId { get; private set; }

        internal static NotebookExternalCitation New(Guid id, Guid articleNotebookId, Guid externalCitationId)
        {
            return new NotebookExternalCitation(id, articleNotebookId, externalCitationId);
        }
        internal static NotebookExternalCitation New(Guid articleNotebookId, Guid externalCitationId)
        {
            return new NotebookExternalCitation(articleNotebookId, externalCitationId);
        }

        public NotebookExternalCitation() : base() { }
        private NotebookExternalCitation(Guid articleNotebookId, Guid externalCitationId)
        {
            ExternalCitationId = externalCitationId;
        }
        private NotebookExternalCitation(Guid id, Guid articleNotebookId, Guid externalCitationId)
        {
            ExternalCitationId = externalCitationId;
        }
    }
}
