using Maritimum.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Maritimum.Repositories
{
    public interface IShipRepository
    {
        Task<Ship> FindById(Guid uuid);

        Task<List<Ship>> FindShips(Guid homePortUuid, int? minTonnage = null, int? maxTonnage = null);

        Task<List<Ship>> FindAll();
    }
}
