using Maritimum.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Maritimum.Repositories
{
    public class ShipRepository : IShipRepository
    {
        private readonly List<Ship> _shipDb;
        private Random _rnd;

        public ShipRepository()
        {
            _shipDb = new List<Ship>
            {
                new Ship
                {
                    Uuid = new Guid("5aacc8a3-353f-4c7e-ae02-41da833b330c"),
                    HomePortUuid = new Guid("28153b3b-f3ac-45d1-820d-fec983a9aa56"),
                    Name = "HQ-01",
                    Tonnage = 10_000
                },
                new Ship
                {
                    Uuid = new Guid("1127e2c5-3c9e-4e5a-adc3-e5247e02eccd"),
                    HomePortUuid = new Guid("28153b3b-f3ac-45d1-820d-fec983a9aa56"),
                    Name = "HQ-02",
                    Tonnage = 20_000
                },
                new Ship
                {
                    Uuid = new Guid("a44eec26-a580-4178-8838-8f77c9f77b81"),
                    HomePortUuid = new Guid("28153b3b-f3ac-45d1-820d-fec983a9aa56"),
                    Name = "HQ-03",
                    Tonnage = 30_000
                },
                new Ship
                {
                    Uuid = new Guid("e85382d2-552c-4745-b7fe-114c2d87e4c3"),
                    HomePortUuid = new Guid("28153b3b-f3ac-45d1-820d-fec983a9aa56"),
                    Name = "HQ-04",
                    Tonnage = 40_000
                },
                new Ship
                {
                    Uuid = new Guid("f336a003-fb63-48b3-8180-80c9f5541fc0"),
                    HomePortUuid = new Guid("f0d4d067-c806-4b1d-a8e6-2080504be61b"),
                    Name = "Seiraimaru",
                    Tonnage = 100_000
                },
            };

            _rnd = new Random();
        }

        public async Task<Ship> FindById(Guid uuid)
        {
            var ship = _shipDb.SingleOrDefault(p => p.Uuid == uuid);
            await Task.Delay(_rnd.Next(1, 50)); // simulate doing work
            return ship;
        }

        public async Task<List<Ship>> FindAll()
        {
            var ships = _shipDb.Select(s => s.Clone()).ToList();
            await Task.Delay(_rnd.Next(1, 50)); // simulate doing work
            return ships;
        }

        public async Task<List<Ship>> FindShips(Guid homePortUuid, int? minTonnage = null, int? maxTonnage = null)
        {
            var ships = _shipDb.Where(s => s.HomePortUuid == homePortUuid);
            if (minTonnage.HasValue)
            {
                ships = ships.Where(s => s.Tonnage >= minTonnage);
            }
            if (maxTonnage.HasValue)
            {
                ships = ships.Where(s => s.Tonnage <= maxTonnage);
            }

            await Task.Delay(_rnd.Next(1, 50)); // simulate doing work

            return ships.Select(s => s.Clone()).ToList();
        }
    }
}
