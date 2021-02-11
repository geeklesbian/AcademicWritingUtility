using AcademicWritingUtility.Domain;
using AcademicWritingUtility.Domain.IRepositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademicWritingUtility.Data.Repositories
{
    /// <summary>
    /// Primary purpose of a base is the reduction of code for declaring and disposing of 
    /// XContext and DbSet. Also, regular repos all use these basic methods. 
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public class Repository<TEntity, TId> : FindRepository<TEntity>, IRepository<TEntity, TId>
        where TId : struct
        where TEntity : class, IBaseClass, new()
    {

        protected Repository() : base() { }

        //[Inject]
        public Repository(string connectionString) : this(new AWUContext(connectionString)) { }
        internal Repository(AWUContext context) : base(context)
        { }
        internal Repository(AWUContext context, string modifiedByid) : base(context, modifiedByid) { }

        protected Repository(string connectionString, string modifiedById) : base(connectionString, modifiedById) { }

        public virtual void Add(ref TEntity entity)
        {
            _dbContext.Entry(entity).State = EntityState.Added;
            _dbSet.Add(entity);
            Save();
        }
        public virtual void Add(TEntity entity)
        {
            this.Add(ref entity);
        }


        public void Update(TEntity entity)
        {
           // entity.SetModified(_modifiedById, DateTime.Now);

            _dbSet.Attach(entity);
            _dbContext.Entry(entity).State = EntityState.Modified;
            Save();
            _dbContext.Entry(entity).State = EntityState.Detached;
            Save();
        }
        public void Update<T, TTId>(T entity, TTId id)
            where TTId : struct
            where T : class, IBaseClass, new()
        {
            TEntity existing = GetById(id);
            _dbContext.Entry(existing).CurrentValues.SetValues(entity);
            Save();
        }
        public void Remove<DId>(DId id)
        {
            Remove(GetById(id));
        }
        public void Remove(TEntity entity)
        {
            //entity.Deactivate(_modifiedById);
            Update(entity);
        }
        public void AddRange(ICollection<TEntity> entities)
        {
            ((DbSet)(_dbSet)).AddRange(entities);
            Save();
        }
        public void Inactivate<T, TDId>(TDId id)
            where TDId : struct
            where T : class, IBaseClass, new()
        {
            DbSet<T> set = _dbContext.Set<T>();
            T entity = set.Find(id);
           // entity.Deactivate(_modifiedById);
            _dbContext.Entry(entity).State = EntityState.Modified;
            Save();
        }
        public T Reactivate<T, TDId>(TDId id)
            where TDId : struct
            where T : class, IBaseClass, new()
        {
            DbSet<T> set = _dbContext.Set<T>();
            T entity = set.Find(id);
            //entity.Reactivate(_modifiedById);
            _dbContext.Entry(entity).State = EntityState.Modified;
            Save();
            return entity;
        }

        public void SetUserId<TUserId>(TUserId userId)
          where TUserId : struct
        {
            throw new NotImplementedException();
        }

    }
    /// <summary>
    /// This is not necessary because it's basically a pass-through for DisposableRepository, but 
    /// it keeps the custom repos consistent. All, regardless of purpose, inherit from BaseRepository.
    /// </summary>
    public class Repository : DisposableRepository
    {

        public void SetUserId<TUserId>(TUserId userId)
          where TUserId : struct
        {
            throw new NotImplementedException();
        }

        protected Repository() : base() { }
       // [Inject]
        public Repository(string connectionString) : this(new AWUContext(connectionString)) { }
        public Repository(AWUContext context) : base(context)
        { }

    }
    public class Repository<TEntity> : FindRepository<TEntity>
        where TEntity : class, new()
    {

        protected Repository() : base() { }

       // [Inject]
        public Repository(string connectionString) : this(new AWUContext(connectionString)) { }
        internal Repository(AWUContext context) : base(context)
        { }

    }
}
