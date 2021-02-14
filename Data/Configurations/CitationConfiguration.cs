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
            Property(p => p.Title).HasColumnType("varchar").IsRequired().HasMaxLength(300);
            Property(p => p.Name).HasColumnType("varchar").IsRequired().HasMaxLength(300);
            Property(p => p.YearPublished).HasColumnType("int").IsRequired();

            HasMany(e => e.ArticleNotebooks).WithRequired(c => c.Citation).HasForeignKey(c => c.CitationId).WillCascadeOnDelete(false);
            HasMany(e => e.CitationFieldValues).WithRequired(c => c.Citation).HasForeignKey(c => c.CitationId).WillCascadeOnDelete(false);
            HasMany(e => e.CitationResearchers).WithRequired(c => c.Citation).HasForeignKey(c => c.CitationId).WillCascadeOnDelete(false);
            HasMany(e => e.ParaPhrases).WithRequired(c => c.Citation).HasForeignKey(c => c.CitationId).WillCascadeOnDelete(false);
        }
    }
}
