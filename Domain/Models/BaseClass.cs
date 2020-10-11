using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademicWritingUtility.Domain.Models
{
    public abstract class BaseClass : IBaseClass
    {
        public Guid Id { get; private set; }

        protected BaseClass() 
        {
            Id = Guid.NewGuid();
        }
        protected BaseClass(Guid id)
        {
            Id = id;
        }
    }
}
