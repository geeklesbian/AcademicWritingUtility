using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademicWritingUtility.Services
{
    public abstract class BaseDTO
    {
        public Guid Id { get; set; }

        protected BaseDTO() 
        {
            Id = Guid.NewGuid();
        }
        protected BaseDTO(Guid id)
        {
            Id = id;
        }
    }
}
