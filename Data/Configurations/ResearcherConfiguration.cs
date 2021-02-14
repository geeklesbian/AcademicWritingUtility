using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AcademicWritingUtility.Domain.Models;

namespace AcademicWritingUtility.Data.Configurations
{
    internal class ResearcherConfiguration : EntityBaseMigrastionMapConfiguration<Researcher>
    {
        internal ResearcherConfiguration() : base()
        {
            HasMany(e => e.CitationResearchers).WithRequired(c => c.Researcher).HasForeignKey(c => c.ResearcherId).WillCascadeOnDelete(false);
        }
    }
}
