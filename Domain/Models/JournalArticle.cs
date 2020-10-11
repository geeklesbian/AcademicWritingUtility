using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademicWritingUtility.Domain.Models
{
    public class JournalArticle : CitationType, IInType<JournalArticle>
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
                throw new Exception($"CitationTypeJA error {x.ToString()}");
            }
        }

        public JournalArticle() : base() { }
        internal JournalArticle(string name, int yearPublished, string fields, string volume, string issue, string pages, string doi)
            : base(name, yearPublished, fields, doi)
        {
            SetValues(volume, issue, pages);
        }
        internal JournalArticle(Guid id, string name, int yearPublished, string fields, string volume, string issue, string pages, string doi)
            : base(id, name, yearPublished, fields, doi)
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
