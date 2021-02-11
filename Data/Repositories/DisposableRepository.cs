using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AcademicWritingUtility.Data.Repositories
{
    public abstract class DisposableRepository : IDisposable
    {
        protected string _modifiedById { get; set; }

        public string ModifiedById => _modifiedById;


        protected AWUContext _dbContext { get; private set; }
        protected DisposableRepository() : base() { }

        protected DisposableRepository(AWUContext context, string modifiedById) : this(context)
        {
            _modifiedById = modifiedById;
        }
        protected DisposableRepository(AWUContext context) : base()
        {
            _dbContext = context;
        }
        protected DisposableRepository(string connectionString, string modifiedById) : this(new AWUContext(connectionString), modifiedById) {}

        public void Save()
        {
            _dbContext.SaveChanges();
        }
        public async Task SaveAsync()
        {
            await _dbContext.SaveChangesAsync();
        }
        public void SetUserId(string userId)
        {
            _modifiedById = userId;
        }
        public void SetUserId(int userId)
        {
            _modifiedById = userId.ToString();
        }

        private bool _isDisposed;
        /// <summary>
        /// Dispose method
        /// </summary>
        public virtual void Dispose()
        {
            Dispose(true);
            //flag GC to not call finalizer
        }

        /// <summary>
        /// Disposes managed/unmanaged resources
        /// </summary>
        /// <param name="disposing"></param>
        protected virtual void Dispose(bool disposing)
        {
            if (_isDisposed) { return; }
            if (disposing)
            {
                if (_dbContext != null) _dbContext.Dispose();
                _dbContext = null;

            }
            _isDisposed = disposing;
        }
        ~DisposableRepository()
        {
            Dispose(false);
        }
    }

    public abstract class DisposableRepository<TEntity> : DisposableRepository
        where TEntity : class, new()
    {
        private bool _isDisposed = false;


        internal DbSet<TEntity> _dbSet;

        internal readonly Expression<Func<TEntity, bool>> _where;

        protected DisposableRepository() : base() { }
        protected DisposableRepository(AWUContext context, string modifiedById) : base(context, modifiedById)
        {
            _dbSet = _dbContext.Set<TEntity>();
        }
        protected DisposableRepository(AWUContext context) : this(context, "")
        { }
        protected DisposableRepository(string connectionString, string modifiedById) : this(new AWUContext(connectionString), modifiedById) { }
        protected DisposableRepository(AWUContext context, Expression<Func<TEntity, bool>> where) : this(context) { _where = where; }


        /// <summary>
        /// Disposes managed/unmanaged resources
        /// </summary>
        /// <param name="disposing"></param>
        protected override void Dispose(bool disposing)
        {
            if (_isDisposed) { return; }
            if (disposing)
            {
                if (_dbSet != null) _dbSet = null;
                _isDisposed = disposing;
                Dispose();
            }
        }
    }
}
