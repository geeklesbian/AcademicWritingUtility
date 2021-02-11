using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademicWritingUtility.Domain.Models
{
    public class JournalArticle : Citation, IInCitation<JournalArticle>
    {
        public string Volume { get; private set; }
        public string Issue { get; private set; }
        public string Pages { get; private set; }

        public JournalArticle New(string data)
        {
            try
            {
                return JsonConvert.DeserializeObject<JournalArticle>(data);
            }
            catch (Exception x)
            {
                throw new Exception($"CitationTypeJA error {x.Message}");
            }
        }

        public JournalArticle() : base() { }
        internal JournalArticle(Guid citationTypeId, string title, string name, int yearPublished, string volume, string issue, string pages, string doi)
            : base(citationTypeId, title, name, yearPublished, doi)
        {
            SetValues(volume, issue, pages);
        }
        internal JournalArticle(Guid id, Guid citationTypeId, string title, string name, int yearPublished, string volume, string issue, string pages, string doi)
            : base(id, citationTypeId, title, name, yearPublished, doi)
        {
            SetValues(volume, issue, pages);
        }
        private void SetValues(string volume, string issue, string pages)
        {
            Volume = volume;
            Issue = issue;
            Pages = pages;
        }
    }
}
