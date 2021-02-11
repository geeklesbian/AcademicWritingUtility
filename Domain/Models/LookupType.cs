using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademicWritingUtility.Domain.Models
{
    public class LookupType : BaseClass
    {
        public string Val { get; private set; }

        public List<Lookup> Lookups => new List<Lookup>();

        public static LookupType New(string val)
        {
            return new LookupType(val);
        }
        public static LookupType New(Guid id, string val)
        {
            return new LookupType(id, val);
        }
        internal LookupType(string val)
            : base()
        {
            Val = val;
        }
        internal LookupType(Guid id, string val) : base(id)
        {
            Val = val;
        }
    }
}
