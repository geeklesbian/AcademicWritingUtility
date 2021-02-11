using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademicWritingUtility.Domain.Models
{
    public class NotebookSection : ArticleNotebookRelated
    {
        public int Order { get; private set; }
        public string Text { get; private set; }

        public static NotebookSection New(Guid id, Guid articleNotebookId, int order, string text)
        {
            return new NotebookSection(id, articleNotebookId, order, text);
        }
        public static NotebookSection New(Guid articleNotebookId, int order, string text)
        {
            return new NotebookSection(articleNotebookId, order, text);
        }

        public NotebookSection() : base() { }
        private NotebookSection(Guid id, Guid articleNotebookId, int order, string text) : base(id, articleNotebookId)
        {
            SetValues(order, text);
        }
        private NotebookSection(Guid articleNotebookId, int order, string text) : base(articleNotebookId)
        {
            SetValues(order, text);
        }
        private void SetValues(int order, string text)
        {
            Order = order;
            Text = text;
        }
    }
}
