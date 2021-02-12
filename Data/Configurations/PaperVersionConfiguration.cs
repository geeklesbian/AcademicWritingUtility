using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AcademicWritingUtility.Domain.Models;

namespace AcademicWritingUtility.Data.Configurations
{
    internal class PaperVersionConfiguration : EntityBaseMigrastionMapConfiguration<PaperVersion>
    {
        internal PaperVersionConfiguration() : base()
        {
            HasMany(e => e.ParaPhrases).WithRequired(c => c.PaperVersion).HasForeignKey(c => c.VersionId).WillCascadeOnDelete(true);
        }
    }
}
