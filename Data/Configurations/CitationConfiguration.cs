using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AcademicWritingUtility.Domain.Models;

namespace AcademicWritingUtility.Data.Configurations
{
    internal class CitationConfiguration : EntityBaseMigrastionMapConfiguration<Citation>
    {
        internal CitationConfiguration() : base()
        {
            HasMany(e => e.CitationFieldValues).WithRequired(c => c.Citation).HasForeignKey(c => c.CitationId).WillCascadeOnDelete(true);
            HasMany(e => e.CitationResearchers).WithRequired(c => c.Citation).HasForeignKey(c => c.ResearcherId).WillCascadeOnDelete(true);
            HasMany(e => e.NotebookCitations).WithRequired(c => c.Citation).HasForeignKey(c => c.CitationId).WillCascadeOnDelete(true);
            HasMany(e => e.NotebookExternalCitations).WithRequired(c => c.ExternalCitation).HasForeignKey(c => c.ExternalCitationId).WillCascadeOnDelete(true);
            HasMany(e => e.ParaPhrases).WithRequired(c => c.Citation).HasForeignKey(c => c.CitationId).WillCascadeOnDelete(true);
        }
    }
}
