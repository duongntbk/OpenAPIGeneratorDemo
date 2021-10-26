using Pecunia.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pecunia.Repositories
{
    public interface IRepository<T> where T : class, ICloneable<T>, IFindable
    {
        Task<T> FindByUuid(Guid uuid);

        Task<List<T>> FindAll();
    }
}
