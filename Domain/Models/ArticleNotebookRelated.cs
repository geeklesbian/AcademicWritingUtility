using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademicWritingUtility.Domain.Models
{
    public abstract class ArticleNotebookRelated : BaseClass
    {
        public Guid ArticleNotebookId { get; private set; }


        public ArticleNotebook ArticleNotebook { get; private set; }

        public ArticleNotebookRelated() : base() { }
        protected ArticleNotebookRelated(Guid id, Guid articleNotebookid) : base(id)
        {
            ArticleNotebookId = articleNotebookid;
        }
        protected ArticleNotebookRelated(Guid articleNotebookId) : base()
        {
            ArticleNotebookId = articleNotebookId;
        }
    }
}
