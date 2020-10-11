using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace AcademicWritingUtility.Domain.Models
{
    public class Online : CitationType, IInType<Online>
    {
        public string Url { get; private set; }
        public string WebSite { get; private set; }
        public string SectionOrHeading { get; private set; }

        public Online New(string data)
        {
            try
            {
                return JsonConvert.DeserializeObject<Online>(data);
            }
            catch (Exception x)
            {
                throw new Exception($"CitationTypeJA error {x.ToString()}");
            }
        }

        public Online() : base() { }
        public Online(string name, int yearPublished, string fields, string url, string webSite, string sectionOrHeading, string doi = "")
            : base(name, yearPublished, fields, doi)
        {
            SetValues(url, webSite, sectionOrHeading);
        }
        public Online(Guid id, string name, int yearPublished, string fields, string url, string webSite, string sectionOrHeading, string doi = "")
            : base(id, name, yearPublished, fields, doi)
        {
            SetValues(url, webSite, sectionOrHeading);
        }
        private void SetValues(string url, string webSite, string sectionOrHeading)
        {
            Url = url;
            WebSite = webSite;
            SectionOrHeading = sectionOrHeading;
        }
    }
}
