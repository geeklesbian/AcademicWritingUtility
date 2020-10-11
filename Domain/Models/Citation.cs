using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademicWritingUtility.Domain.Models
{
    public class Citation : BaseClass
    {
        public Guid CitationTypeId { get; private set; }
        public string Title { get; private set; } 

    }
}
