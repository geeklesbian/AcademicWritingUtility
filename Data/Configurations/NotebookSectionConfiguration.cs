using AcademicWritingUtility.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademicWritingUtility.Data.Configurations
{
    internal class NotebookSectionConfiguration : EntityBaseMigrastionMapConfiguration<NotebookSection>
    {
        internal NotebookSectionConfiguration() : base()
        {
            HasRequired(c => c.ArticleNotebook).WithMany(e => e.NotebookSections).HasForeignKey(c => c.ArticleNotebookId).WillCascadeOnDelete(false);
        }
    }
}
