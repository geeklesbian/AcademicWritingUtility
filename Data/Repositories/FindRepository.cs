using AcademicWritingUtility.Domain.IRepositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademicWritingUtility.Data.Repositories
{
    public class FindRepository<TEntity> : DisposableRepository, IFindRepository<TEntity>
                where TEntity : class, new()
    {
        protected DbSet<TEntity> _dbSet;
        public FindRepository() : base() { }
        public FindRepository(AWUContext context) : base(context) { }
        protected FindRepository(string connectionString, string modifiedById) : base(connectionString, modifiedById) { }
        protected FindRepository(AWUContext context, string modifiedById) : base(context, modifiedById) { }
        public List<TEntity> AsList()
        {
            return GetAll().ToList();
        }

        public IQueryable<TEntity> AsNoTracking()
        {
            return _dbSet.AsNoTracking();
        }

        public IQueryable<TEntity> GetAll()
        {
            return _dbSet;
        }

        public TEntity GetByCompositeId<TKey>(TKey tId1, TKey tId2)
        {
            return _dbSet.Find(tId1, tId2);
        }

        public TEntity GetById<TId>(TId id)
        {
            return _dbSet.Find(id);
        }

        private bool _isDisposed = false;
        public override void Dispose()
        {
            this.Dispose(true);
        }
        protected override void Dispose(bool disposing)
        {
            if(!_isDisposed && disposing && _dbSet != null)
            {
                _dbSet = null;
                _isDisposed = disposing;
            }
            base.Dispose(disposing);
        }
    }
    public class FindRepository<TEntity, TId> : FindRepository<TEntity>, IFindRepository<TEntity, TId>
        where TEntity : class, new()
        where TId : struct
    {
        public TEntity Get(TId id)
        {
            return _dbSet.Find(id);
        }

        public FindRepository() : base() { }
        internal FindRepository(AWUContext context) : base(context)
        {
            _dbSet = context.Set<TEntity>();
        }
        private bool _isDisposed = false;
        public override void Dispose()
        {
            base.Dispose(true);
        }
        protected override void Dispose(bool dispose)
        {
            if(!_isDisposed && dispose && _dbSet != null)
            {
                _dbSet = null;
            }
            base.Dispose(dispose);
        }
    }
}
