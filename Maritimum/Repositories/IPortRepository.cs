using Maritimum.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Maritimum.Repositories
{
    public interface IPortRepository
    {
        Task<Port> FindById(Guid uuid);

        public Task<List<Port>> FindPorts(string country, bool? isDeepWater = null);

        public Task<List<Port>> FindAll();
    }
}
