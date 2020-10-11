using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademicWritingUtility.Domain.Models
{
    public class CitationType : BaseClass
    {
        public string Name { get; private set; }



        public CitationType() : base() { }
        public CitationType(string name) : base() 
        {
            SetValues(name);
        }
        public CitationType(Guid id, string name) : base(id)
        {
            SetValues(name);
        }
        private void SetValues(string name)
        {
            Name = name;
        }
    }
}
