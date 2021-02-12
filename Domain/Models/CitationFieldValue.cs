using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademicWritingUtility.Domain.Models
{
    public class CitationFieldValue : BaseClass
    {

        public Guid CitationId { get; private set; }
        public Guid FieldId { get; private set; }
        public string Val { get; private set; }

        public Citation Citation { get; set; }
        public Lookup Field { get; set; }

        internal static CitationFieldValue New(Guid id, Guid citationId, Guid fieldId, string val)
        {
            return new CitationFieldValue(id, citationId, fieldId, val);
        }
        internal static CitationFieldValue New(Guid citationId, Guid fieldId, string val)
        {
            return new CitationFieldValue(citationId, fieldId, val);
        }
        public CitationFieldValue() : base()
        { }
        internal CitationFieldValue(Guid id, Guid citationId, Guid fieldId, string val) : base(id)
        {
            SetValues(citationId, fieldId, val);
        }
        internal CitationFieldValue(Guid citationId, Guid fieldId, string val) : base()
        {
            SetValues(citationId, fieldId, val);
        }
        private void SetValues(Guid citationId, Guid fieldId, string val)
        {
            CitationId = citationId;
            FieldId = fieldId;
            Val = val;
        }
    }
}
