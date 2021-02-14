using AcademicWritingUtility.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademicWritingUtility.Data.Configurations
{
    internal class NotebookParaPhraseConfiguration : EntityBaseMigrastionMapConfiguration<NotebookParaPhrase>
    {
        internal NotebookParaPhraseConfiguration() : base()
        {
            HasRequired(c => c.ArticleNotebook).WithMany(e => e.NotebookParaPhrases).HasForeignKey(c => c.ArticleNotebookId).WillCascadeOnDelete(false);
            HasRequired(c => c.ParaPhrase).WithMany(e => e.NotebookParaPhrases).HasForeignKey(c => c.ParaPhraseId).WillCascadeOnDelete(false);
        }
    }
}
