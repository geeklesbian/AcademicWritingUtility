using AcademicWritingUtility.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademicWritingUtility.Data.Configurations
{
    internal class NotebookCitationConfiguration : EntityBaseMigrastionMapConfiguration<NotebookCitation>
    {
        internal NotebookCitationConfiguration() : base()
        {
            HasRequired(c => c.ArticleNotebook).WithMany(e => e.NotebookCitations).HasForeignKey(c => c.ArticleNotebookId).WillCascadeOnDelete(false);
            HasRequired(c => c.Citation).WithMany(e => e.NotebookCitations).HasForeignKey(c => c.CitationId).WillCascadeOnDelete(false);
        }
    }
}
