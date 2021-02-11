using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademicWritingUtility.Services.DTOs
{
    public class CitationField : BaseDTO
    {
        public Guid CitationTypeId { get; private set; }
        public string Name { get; private set; }

        public static CitationField New(Guid citationTypeId, string name)
        {
            return new CitationField(citationTypeId, name);
        }
        public static CitationField New(Guid id, Guid citationTypeId, string name)
        {
            return new CitationField(id, citationTypeId, name);
        }
        public CitationField(Guid citationTypeId, string name) : base()
        {
            SetValues(citationTypeId, name);
        }
        public CitationField(Guid id, Guid citationTypeId, string name) : base(id)
        {
            SetValues(citationTypeId, name);
        }
        private void SetValues(Guid citationTypeId, string name)
        {
            CitationTypeId = citationTypeId;
            Name = name;
        }
    }
}
