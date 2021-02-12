using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AcademicWritingUtility.Domain.Models;

namespace AcademicWritingUtility.Data.Configurations
{
    internal class ArticleNotebookConfiguration : EntityBaseMigrastionMapConfiguration<ArticleNotebook>
    {
        internal ArticleNotebookConfiguration() : base()
        {
            HasMany(e => e.Sections).WithRequired(c => c.ArticleNotebook).HasForeignKey(c => c.ArticleNotebookId).WillCascadeOnDelete(true);
            HasMany(e => e.Citations).WithRequired(c => c.ArticleNotebook).HasForeignKey(c => c.ArticleNotebookId).WillCascadeOnDelete(true);
            HasMany(e => e.ExternalCitations).WithRequired(c => c.ArticleNotebook).HasForeignKey(c => c.ArticleNotebookId).WillCascadeOnDelete(true);
        }
    }
}
