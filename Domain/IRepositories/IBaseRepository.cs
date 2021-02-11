using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademicWritingUtility.Domain.IRepositories
{
    public interface IBaseRepository : IDisposable
    {
        void SetUserId<TUserId>(TUserId userId)
            where TUserId : struct;
        void SetUserId(string userId);

        void Inactivate<T, TId>(TId id)
            where TId : struct
            where T : class, IBaseClass, new();
        T Reactivate<T, TId>(TId id) where TId : struct
            where T : class, IBaseClass, new();
    }
}
