using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademicWritingUtility.Domain.Models
{
    public class Draft : BaseClass
    {
        public string Name { get; private set; }

        public List<Version> Versions { get; set; } = new List<Version>();

        public Draft() : base() { }
        public Draft(string name) : base()
        {
            Name = name;
        }
        public Draft(Guid id, string name) : base(id)
        {
            Name = name;
        }
    }
}
