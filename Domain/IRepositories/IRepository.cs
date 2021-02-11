using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademicWritingUtility.Domain.IRepositories
{
    public interface IRepository<TEntity> : IFindRepository<TEntity>, IDisposable
        where TEntity : class, new()
    {
        /// <summary>
        /// Hard delete by Id.
        /// </summary>
        /// <typeparam name="TId"></typeparam>
        /// <param name="id"></param>
        void Remove<TId>(TId id);
        /// <summary>
        /// Remove should only be used as a Delete if it is a child of something that is allowed to be deleted. Otherwise, it should be a "Soft Delete", which is a Deactivate().
        /// </summary>
        /// <param name="entity"></param>
        void Remove(TEntity entity);
        /// <summary>
        /// Generic update. No safe-guards. No checking. Just throws the entity in for an update.
        /// </summary>
        /// <param name="entity">TEntity per the LTRepository definition parameter.</param>
        void Update(TEntity entity);

        /// <summary>
        /// Add as a procedure. ref to get it back out if the Id is an auto-incremented/created struct (int/Guid)
        /// </summary>
        /// <param name="entity"></param>
        void Add(ref TEntity entity);
        /// <summary>
        /// Add as a procedure. No return.
        /// </summary>
        /// <param name="entity"></param>
        void Add(TEntity entity);

        /// <summary>
        /// Add a range of entities.
        /// </summary>
        /// <param name="entities"></param>
        void AddRange(ICollection<TEntity> entities);
    }
    public interface IRepository<T, TId> : IRepository<T>, IBaseRepository
    where TId : struct
    where T : class, IBaseClass, new()
    {
    }
}
