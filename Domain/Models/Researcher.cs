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

        public List<Citation> Citations { get; set; } = new List<Citation>();

        public Researcher() : base() { }
        public Researcher(string lastName, string initials) : base()
        {
            SetValues(lastName, initials);
        }
        public Researcher(Guid id, string lastName, string initials) : base(id)
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
