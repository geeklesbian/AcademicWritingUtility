using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademicWritingUtility.Domain.Models
{
    public class Publisher : Citation, IInCitation<Publisher>
    {
        public string CityState { get; private set; }
        public Guid CountryId { get; private set; }
        public string ISBN { get; private set; }

        public Publisher New(string data)
        {
            try
            {
                return JsonConvert.DeserializeObject<Publisher>(data);
            }
            catch (Exception x)
            {
                throw new Exception($"CitationTypeP error {x.Message}");
            }
        }
        public static Publisher New(Guid id, Guid citationTypeId, string title, string name, int yearPublished, string cityState, Guid countryId, string isbn = "", string doi = "")
        {
            return new Publisher(id, citationTypeId, title, name, yearPublished, cityState, countryId, isbn, doi);
        }
        public static Publisher New( Guid citationTypeId, string title, string name, int yearPublished, string cityState, Guid countryId, string isbn = "", string doi = "")
        {
            return new Publisher(citationTypeId, title, name, yearPublished, cityState, countryId, isbn, doi);
        }

        public Publisher() : base() { }
        internal Publisher(Guid citationTypeId, string title, string name, int yearPublished, string cityState, Guid countryId, string isbn, string doi)
            : base(citationTypeId, title, name, yearPublished, doi)
        {
            SetValues(cityState, countryId, isbn);
        }
        internal Publisher(Guid id, Guid citationTypeId, string title, string name, int yearPublished, string cityState, Guid countryId, string isbn, string doi)
            : base(id, citationTypeId, title, name, yearPublished, doi)
        {
            SetValues(cityState, countryId, isbn);
        }

        private void SetValues(string cityState, Guid countryId, string isbn)
        {
            CityState = cityState;
            CountryId = countryId;
            ISBN = isbn;
        }
    }
}
