using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademicWritingUtility.Domain.Models
{
    public class Publisher : CitationType, IInType<Publisher>
    {
        public string CityState { get; private set; }
        public string CountryAbbreviation { get; private set; }
        public string ISBN { get; private set; }

        public Publisher New(string data)
        {
            try
            {
                return JsonConvert.DeserializeObject<Publisher>(data);
            }
            catch (Exception x)
            {
                throw new Exception($"CitationTypeP error {x.ToString()}");
            }
        }

        public Publisher() : base() { }
        public Publisher(string name, int yearPublished, string fields, string cityState, string isbn, string countryAbbreviation = "U.S.", string doi = "")
            : base(name, yearPublished, fields, doi)
        {
            SetValues(cityState, countryAbbreviation, isbn);
        }
        public Publisher(Guid id, string name, int yearPublished, string fields, string cityState, string isbn, string countryAbbreviation = "U.S.", string doi = "")
            : base(id, name, yearPublished, fields, doi)
        {
            SetValues(cityState, countryAbbreviation, isbn);
        }

        private void SetValues(string cityState, string countryAbbreviation string isbn)
        {
            CityState = cityState;
            CountryAbbreviation = countryAbbreviation;
            ISBN = isbn;
        }
    }
}
