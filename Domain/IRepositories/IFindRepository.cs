using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademicWritingUtility.Domain.IRepositories
{
    public interface IFindRepository<TEntity> : IDisposable
    {
        /// <summary>
        /// As no tracking removes the _dbSet from the graph and prevents lazy loading. Allows comples Linq in services against the server instead of the client or application server.
        /// </summary>
        /// <returns></returns>
        IQueryable<TEntity> AsNoTracking();

        /// <summary>
        /// Standard GetAll() with lazy loading.
        /// </summary>
        /// <returns></returns>
        IQueryable<TEntity> GetAll();
        /// <summary>
        /// GetAll as a List(Of TEntity). Best when used for lookups. Hits performance when used for a regular data table.
        /// </summary>
        /// <returns></returns>
        List<TEntity> AsList();
        
        /// <summary>
        /// Finds the entity by id. TId is self-defined. It'll be a struct of some kind.
        /// </summary>
        /// <typeparam name="TId"></typeparam>
        /// <param name="id"></param>
        /// <returns></returns>
        TEntity GetById<TId>(TId id);
        /// <summary>
        /// TKey can be anything. User would define at the time of programming.
        /// </summary>
        /// <typeparam name="TKey"></typeparam>
        /// <param name="tId1"></param>
        /// <param name="tId2"></param>
        /// <returns></returns>
        TEntity GetByCompositeId<TKey>(TKey tId1, TKey tId2);
    }
    public interface IFindRepository<TEntity, TId> : IFindRepository<TEntity>
    {
        TEntity Get(TId id);
    }

}
