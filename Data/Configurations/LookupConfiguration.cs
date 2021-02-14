using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademicWritingUtility.Data.Configurations
{
    internal class LookupConfiguration : EntityBaseMigrastionMapConfiguration<Domain.Models.Lookup>
    {
        internal LookupConfiguration() : base()
        {
            HasMany(e => e.Citations).WithRequired(c => c.CitationType).HasForeignKey(c => c.CitationTypeId).WillCascadeOnDelete(false);
            HasMany(e => e.CitationFieldValues).WithRequired(c => c.Field).HasForeignKey(c => c.FieldId).WillCascadeOnDelete(false);
        }
    }
}
