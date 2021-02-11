using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademicWritingUtility.Data
{
    public class AWUContext : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Add<ForeignKeyNamingConvention>();
        }

        #region Entities
        #endregion

        public AWUContext(string nameOrConnectionString) : base(nameOrConnectionString) 
        {
            Database.SetInitializer<AWUContext>(null);
        }
        public AWUContext() : this(@"data source=localhost\SQL2019;initial catalog=AcademicWritingUtility;persist security info=True;user id=AcademicWritingUtilityUser;password=@c@d3m!c;MultipleActiveResultSets=True;App=EntityFramework")
        { }

    }
}
