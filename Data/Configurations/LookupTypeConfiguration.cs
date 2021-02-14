using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AcademicWritingUtility.Domain.Models;

namespace AcademicWritingUtility.Data.Configurations
{
    internal class LookupTypeConfiguration : EntityBaseMigrastionMapConfiguration<LookupType>
    {
        internal LookupTypeConfiguration() : base()
        {
            HasMany(e => e.Lookups).WithRequired(c => c.LookupType).HasForeignKey(c => c.LookupTypeId).WillCascadeOnDelete(false);
        }
    }
}
