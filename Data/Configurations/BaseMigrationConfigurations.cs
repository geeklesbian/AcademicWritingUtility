using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using System.Reflection;
using System.Data.Entity.ModelConfiguration.Configuration;

namespace TC.Data.EntityFramework.MigrationConfigurations
{
    //public static class ConfigurationExtensions<TEntity> : EntityTypeConfiguration<TEntity>
    //{
    //    public static ICollection<StringPropertyConfiguration> AddMultiColumnIndex<TEntity>(ICollection<TProperties> properties)
    //    {
    //        foreach (PropertyInfo propertyInfo in typeof(TEntity).GetProperties())
    //        Property(x => x.Email).HasMaxLength(255).AddMultiColumnIndex("UX_User_EmailShopId", 0, unique: true);
    //        modelBuilder.Entity<User>().Property(x => x.ShopId).AddMultiColumnIndex("UX_User_EmailShopId", 1, unique: true);
    //      }
    //    }
    //}
    //public class BaseMigrationMapConfiguration<TEntity> : EntityTypeConfiguration<TEntity>
    // where TEntity : class, IEntityBase
    //{
    //    public BaseMigrationMapConfiguration() : base() {
    //        Property(e => e.IsActive).IsRequired();
    //        Property(e => e.LastModifiedDate).IsRequired();
    //     }
    //}
    public class EntityBaseMigrastionMapConfiguration<TEntity, TId> : EntityTypeConfiguration<TEntity>
        where TEntity : class
        where TId : struct
    {
        public EntityBaseMigrastionMapConfiguration() : base() 
        {
            HasKey(e => e.Id);
            Property(e => e.IsActive).IsRequired();
            Property(e => e.LastModifiedDate).IsRequired();
        }
    }
    public class EntityMigrationConfiguration<TEntity, TId> : EntityBaseMigrastionMapConfiguration<TEntity, TId>
        where TEntity : class, IEntityBase<TId>
        where TId : struct
        where TModifyingUserId : struct
    {
        public EntityMigrationConfiguration() : base() 
        {
            Property(e => e.CreatedDate).IsRequired();
            Property(e => e.CreatedById).IsRequired();
            Property(e => e.ModifiedById).IsRequired();

        }

    }

    //public class BasePersonMigrationConfiguration<TEntity, TId> : EntityMigrationConfiguration<TEntity, TId>
    //    where TEntity : class, IPerson<TId>
    //    where TId : struct
    //    where TModifyingUserId : struct
    //{
    //    public BasePersonMigrationConfiguration() : base() 
    //    {
    //        Property(e => e.FirstName).HasMaxLength(50).HasColumnType("varchar");
    //        Property(e => e.LastName).HasMaxLength(50).HasColumnType("varchar");
    //        Property(e => e.PreferredFirstName).HasMaxLength(50).HasColumnType("varchar");
    //        Property(e => e.Salutation).HasMaxLength(25).HasColumnType("varchar");
    //        Property(e => e.MiddleName).HasMaxLength(50).HasColumnType("varchar");
    //        Property(e => e.NickName).HasMaxLength(50).HasColumnType("varchar");
    //        Property(e => e.Prefix).HasMaxLength(10).HasColumnType("varchar");
    //        Property(e => e.Suffix).HasMaxLength(10).HasColumnType("varchar");
    //    }
    //}
    //public class BasePersonIgnoreColumnsWithMigrationConfiguration<TEntity, TId, TModifyingUserId> : BasePersonMigrationConfiguration<TEntity, TId, TModifyingUserId>
    //    where TEntity : class, IPerson<TId, TModifyingUserId>
    //    where TId : struct
    //    where TModifyingUserId : struct
    //{
    //    public BasePersonIgnoreColumnsWithMigrationConfiguration() : base() 
    //    {
    //        Ignore(e => e.Salutation);
    //        Ignore(e => e.MiddleName);
    //        Ignore(e => e.NickName);
    //        Ignore(e => e.Prefix);
    //        Ignore(e => e.Suffix);
    //    }
    //}
    //public class BaseEmployeeMigrationConfiguration<TEntity, TId, TModifyingUserId> : BasePersonMigrationConfiguration<TEntity, TId, TModifyingUserId>
    //    where TEntity : class, IEmployee<TId, TModifyingUserId>
    //    where TId : struct
    //    where TModifyingUserId : struct
    //{
    //    public BaseEmployeeMigrationConfiguration() : base()
    //    {
    //        Property(e => e.WorkforceId).HasMaxLength(6).HasColumnType("varchar");
    //        Property(e => e.JobCode).HasMaxLength(10).HasColumnType("varchar");
    //        Property(e => e.Title).HasMaxLength(10).HasColumnType("varchar");
    //        Property(e => e.JobCode).HasMaxLength(10).HasColumnType("varchar");
    //        Property(e => e.UnitNumber).HasMaxLength(4).HasColumnType("varchar");
    //    }
    //}
    //public class BaseEmployeeIgnoreColumnsWithMigrationConfiguration<TEntity, TId, TModifyingUserId> : BaseEmployeeMigrationConfiguration<TEntity, TId, TModifyingUserId>
    //    where TEntity : class, IEmployee<TId, TModifyingUserId>
    //    where TId : struct
    //    where TModifyingUserId : struct
    //{
    //    public BaseEmployeeIgnoreColumnsWithMigrationConfiguration() : base() 
    //    {
    //        Ignore(e => e.JobCode);
    //        Ignore(e => e.Title);
    //        Ignore(e => e.JobCode);
    //        Ignore(e => e.UnitNumber);
    //        Ignore(e => e.BargainingUnit);
    //    }
    //}
    //public class EmployeeBaseMigrationConfiguration<TEntity, TId, TModifyingUserId> : EntityBaseMigrastionMapConfiguration<TEntity, TId>
    //    where TEntity : class, IEntityBase<TId>, IEmployee<TId, TModifyingUserId>
    //{
    //    public EmployeeBaseMigrationConfiguration() : base() 
    //    {
    //        Property(e => e.DepartmentId).IsRequired();
    //    }
    //}
    //public class EntityBaseMigrationConfiguration<TEntity, TId> : EntityBaseMigrationConfiguration<TEntity>
    //where TEntity : class, IEntityBase, IEntityBase<TId>
    //{
    //    public EntityBaseMigrationConfiguration() : base() {
    //    }
    //}
}
