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

        public List<PaperVersion> Versions { get; set; } = new List<PaperVersion>();

        public static Draft New(Guid id, string name)
        {
            return new Draft(id, name);
        }
        public static Draft New(string name)
        {
            return new Draft(name);
        }

        public Draft() : base() { }
        internal Draft(string name) : base()
        {
            Name = name;
        }
        internal Draft(Guid id, string name) : base(id)
        {
            Name = name;
        }
    }
}
