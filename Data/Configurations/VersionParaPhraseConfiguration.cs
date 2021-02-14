using AcademicWritingUtility.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademicWritingUtility.Data.Configurations
{
    internal class VersionParaPhraseConfiguration : EntityBaseMigrastionMapConfiguration<VersionParaPhrase>
    {
        internal VersionParaPhraseConfiguration() : base()
        {
            HasRequired(c => c.PaperVersion).WithMany(e => e.VersionParaPhrases).HasForeignKey(c => c.VersionId).WillCascadeOnDelete(false);
            HasRequired(c => c.ParaPhrase).WithMany(e => e.VersionParaPhrases).HasForeignKey(c => c.ParaPhraseId).WillCascadeOnDelete(false);
        }
    }
}
