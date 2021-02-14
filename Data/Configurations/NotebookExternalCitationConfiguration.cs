using AcademicWritingUtility.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademicWritingUtility.Data.Configurations
{
    internal class NotebookExternalCitationConfiguration : EntityBaseMigrastionMapConfiguration<NotebookExternalCitation>
    {
        internal NotebookExternalCitationConfiguration() : base()
        {
            HasRequired(c => c.ArticleNotebook).WithMany(e => e.NotebookExternalCitations).HasForeignKey(c => c.ArticleNotebookId).WillCascadeOnDelete(false);
            HasRequired(c => c.ExternalCitation).WithMany(e => e.NotebookExternalCitations).HasForeignKey(c => c.ExternalCitationId).WillCascadeOnDelete(false);
        }
    }
}
