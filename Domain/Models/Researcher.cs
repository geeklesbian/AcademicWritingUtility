using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademicWritingUtility.Domain.Models
{
    public class Researcher : BaseClass
    {
        public string LastName { get; protected set; }
        public string Initials { get; protected set; }

        public List<CitationResearcher> CitationResearchers => new List<CitationResearcher>();

        public static Researcher New(string lastName, string initials)
        {
            return new Researcher(lastName, initials);
        }
        public static Researcher New(Guid id, string lastName, string initials)
        {
            return new Researcher(id, lastName, initials);
        }
        public Researcher() : base() { }
        internal Researcher(string lastName, string initials) : base()
        {
            SetValues(lastName, initials);
        }
        internal Researcher(Guid id, string lastName, string initials) : base(id)
        {
            SetValues(lastName, initials);
        }
        private void SetValues(string lastName, string initials)
        {
            LastName = lastName;
            Initials = initials;
        }
    }
}
