using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace AcademicWritingUtility.Domain.Models
{
    public class Online : Citation, IInCitation<Online>
    {
        public string Url { get; private set; }
        public string WebSite { get; private set; }
        public string SectionOrHeading { get; private set; }
        public DateTime RetrievedDate { get; private set; }

        public Online New(string data)
        {
            try
            {
                return JsonConvert.DeserializeObject<Online>(data);
            }
            catch (Exception x)
            {
                throw new Exception($"CitationTypeO error {x.Message}");
            }
        }
        public static Online New(Guid citationTypeId, string title, string name, int yearPublished, string url, string webSite, DateTime retrievedDate = default(DateTime), string doi, string sectionOrHeading = "")
        {
            if (retrievedDate == default(DateTime))
            {
                retrievedDate = DateTime.Now;
            }
            return new Online(citationTypeId, title, name, yearPublished, url, webSite, retrievedDate, sectionOrHeading, doi);
        }
        public static Online New(Guid id, Guid citationTypeId, string title, string name, int yearPublished, string url, string webSite, DateTime retrievedDate = default(DateTime), string doi, string sectionOrHeading = "")
        {
            if(retrievedDate == default(DateTime))
            {
                retrievedDate = DateTime.Now;
            }
            return new Online(id, citationTypeId, title, name, yearPublished, url, webSite, retrievedDate, sectionOrHeading, doi);
        }
        public Online() : base() { }
        internal Online(Guid citationTypeId,  string title, string name, int yearPublished, string url, string webSite, DateTime retrievedDate, string sectionOrHeading, string doi)
            : base(citationTypeId, title, name, yearPublished, doi)
        {
            SetValues(url, webSite, retrievedDate, sectionOrHeading);
        }
        internal Online(Guid id, Guid citationTypeId, string title, string name, int yearPublished, string url, string webSite, DateTime retrievedDate, string sectionOrHeading, string doi)
            : base(id, citationTypeId, title, name, yearPublished, doi)
        {
            SetValues(url, webSite, retrievedDate, sectionOrHeading);
        }
        private void SetValues(string url, string webSite, DateTime retrievedDate, string sectionOrHeading)
        {
            Url = url;
            WebSite = webSite;
            RetrievedDate = retrievedDate;
            SectionOrHeading = sectionOrHeading;
        }
    }
}
