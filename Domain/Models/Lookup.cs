using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademicWritingUtility.Domain.Models
{
    public class Lookup : BaseClass
    {
        public Guid LookupTypeId { get; private set; }
        public string Val { get; private set; }

        public List<Citation> Citations { get; set; } = new List<Citation>();
        public List<CitationFieldValue> CitationFieldValues { get; set; } = new List<CitationFieldValue>();

        public LookupType LookupType { get; private set; }

        public static Lookup New(Guid lookupTypeId, string val)
        {
            return new Lookup(lookupTypeId, val);
        }
        public static Lookup New(Guid id, Guid lookupTypeId, string val)
        {
            return new Lookup(id, lookupTypeId, val);
        }
        internal Lookup(Guid lookupTypeId, string val) : base()
        {
            SetValues(lookupTypeId, val);
        }
        internal Lookup(Guid id, Guid lookupTypeId, string val) : base(id)
        {
            SetValues(lookupTypeId, val);
        }
        private void SetValues(Guid lookupTypeId, string val)
        {
            LookupTypeId = lookupTypeId;
            Val = val;
        }
    }
}
