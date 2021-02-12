using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using System.Reflection;
using System.Data.Entity.ModelConfiguration.Configuration;

using AcademicWritingUtility.Domain;

namespace AcademicWritingUtility.Data.Configurations
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
    //public abstract class BaseMigrationMapConfiguration<TEntity> : EntityTypeConfiguration<TEntity>
    // where TEntity : class, IEntityBase
    //{
    //    public BaseMigrationMapConfiguration() : base() {
    //        Property(e => e.IsActive).IsRequired();
    //        Property(e => e.LastModifiedDate).IsRequired();
    //     }
    //}
    public abstract class EntityBaseMigrastionMapConfiguration<TEntity> : EntityTypeConfiguration<TEntity>
        where TEntity : class, IBaseClass
    {
        public EntityBaseMigrastionMapConfiguration() : base() 
        {
            HasKey(e => e.Id);
        }
    }
    //public abstract class EntityMigrationConfiguration<TEntity, TId> : EntityBaseMigrastionMapConfiguration<TEntity, TId>
    //    where TEntity : class, IBaseClass
    //    where TId : struct
    //{
    //    public EntityMigrationConfiguration() : base() 
    //    {
    //        Property(e => e.CreatedDate).IsRequired();
    //        Property(e => e.CreatedById).IsRequired();
    //        Property(e => e.ModifiedById).IsRequired();

    //    }

    //}

    //public abstract class BasePersonMigrationConfiguration<TEntity, TId> : EntityMigrationConfiguration<TEntity, TId>
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
    //public abstract class BasePersonIgnoreColumnsWithMigrationConfiguration<TEntity, TId, TModifyingUserId> : BasePersonMigrationConfiguration<TEntity, TId, TModifyingUserId>
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
    //public abstract class BaseEmployeeMigrationConfiguration<TEntity, TId, TModifyingUserId> : BasePersonMigrationConfiguration<TEntity, TId, TModifyingUserId>
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
    //public abstract class BaseEmployeeIgnoreColumnsWithMigrationConfiguration<TEntity, TId, TModifyingUserId> : BaseEmployeeMigrationConfiguration<TEntity, TId, TModifyingUserId>
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
