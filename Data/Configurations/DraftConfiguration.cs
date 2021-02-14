using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AcademicWritingUtility.Domain.Models;

namespace AcademicWritingUtility.Data.Configurations
{
    internal class DraftConfiguration : EntityBaseMigrastionMapConfiguration<Draft> 
    {
        internal DraftConfiguration() : base()
        {
            HasMany(e => e.Versions).WithRequired(c => c.Draft).HasForeignKey(c => c.DraftId).WillCascadeOnDelete(false);
        }
    }
}
