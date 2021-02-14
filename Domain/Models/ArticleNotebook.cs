using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademicWritingUtility.Domain.Models
{
    public class ArticleNotebook : BaseClass
    {
        public Guid CitationId { get; private set; }

        public List<NotebookSection> NotebookSections { get; set; } = new List<NotebookSection>();
        public List<NotebookCitation> NotebookCitations { get; set; } = new List<NotebookCitation>();
        public List<NotebookExternalCitation> NotebookExternalCitations { get; set; } = new List<NotebookExternalCitation>();
        public List<NotebookParaPhrase> NotebookParaPhrases { get; set; } = new List<NotebookParaPhrase>();

        public Citation Citation { get; private set; }

        public static ArticleNotebook New(Guid id, Guid citationId)
        {
            return new ArticleNotebook(id, citationId);
        }
        public static ArticleNotebook New(Guid citationId)
        {
            return new ArticleNotebook(citationId);
        }
        public NotebookSection NewNotebookSection()
        {
            int sectionNumber = 1;
            if(NotebookSections.Count > 0) { sectionNumber = NotebookSections.Max(s => s.Order) + 1; }
            return NotebookSection.New(this.Id, sectionNumber, "");
        }
        public static NotebookSection NewNotebookSection(Guid id, Guid articleNotebookid, int order, string text)
        {
            return NotebookSection.New(id, articleNotebookid, order, text);
        }
        public NotebookCitation NewNotebookCitation(Guid citationId)
        {
            return NotebookCitation.New(this.Id, citationId);
        }
        public static NotebookCitation NewNotebookCitation(Guid id, Guid articleNotebookId, Guid citationid)
        {
            return NotebookCitation.New(id, articleNotebookId, citationid);
        }
        public NotebookExternalCitation NewNotebookExternalCitation(Guid citationId)
        {
            return NotebookExternalCitation.New(this.Id, citationId);
        }
        public static NotebookExternalCitation NewNotebookExternalCitation(Guid id, Guid articleNotebookid, Guid citationId)
        {
            return NotebookExternalCitation.New(id, articleNotebookid, citationId);
        }
        public NotebookParaPhrase NewNotebookParaPhrase(Guid paraPhraseId)
        {
            return NotebookParaPhrase.New(this.Id, paraPhraseId);
        }
        public static NotebookParaPhrase NewNotebookParaPhrase(Guid id, Guid articleNotebookId, Guid paraPhraseid)
        {
            return NotebookParaPhrase.New(id, articleNotebookId, paraPhraseid);
        }

        public ArticleNotebook(): base() { }
        internal ArticleNotebook(Guid id, Guid citationid) : base(id)
        {
            CitationId = citationid;
        }
        internal ArticleNotebook(Guid citationId) : base()
        {
            CitationId = citationId;
        }
    }
}
