using Maritimum.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Maritimum.Repositories
{
    public class PortRepository : IPortRepository
    {
        private readonly List<Port> _portDb;
        private readonly Random _rnd;

        public PortRepository()
        {
            _portDb = new List<Port>
            {
                new Port
                {
                    Uuid = new Guid("28153b3b-f3ac-45d1-820d-fec983a9aa56"),
                    Name = "Haiphong",
                    Country = "Vietnam",
                    IsDeepWater = true
                },
                new Port
                {
                    Uuid = new Guid("d6270775-1104-4db7-b4c2-315403b73852"),
                    Name = "Saigon",
                    Country = "Vietnam",
                    IsDeepWater = true
                },
                new Port
                {
                    Uuid = new Guid("2dd67bf0-938c-4fe8-ae35-ee7a2ab4ff2d"),
                    Name = "Nha Trang",
                    Country = "Vietnam",
                    IsDeepWater = false
                },
                new Port
                {
                    Uuid = new Guid("b5cf7d02-afce-46a0-a22c-83d60944984f"),
                    Name = "Vung Tau",
                    Country = "Vietnam"
                },
                new Port
                {
                    Uuid = new Guid("1a8ff939-9cc2-4089-b941-3ee9d04f3a96"),
                    Name = "Yokohama",
                    Country = "Japan",
                    IsDeepWater = true
                },
                new Port
                {
                    Uuid = new Guid("f0d4d067-c806-4b1d-a8e6-2080504be61b"),
                    Name = "Kawasaki",
                    Country = "Japan",
                    IsDeepWater = false
                },
            };

            _rnd = new Random();
        }

        public async Task<Port> FindById(Guid uuid)
        {
            var port = _portDb.SingleOrDefault(p => p.Uuid == uuid);
            await Task.Delay(_rnd.Next(1, 50)); // simulate doing work
            return port;
        }

        public async Task<List<Port>> FindAll()
        {
            var ports = _portDb.Select(p => p.Clone()).ToList();
            await Task.Delay(_rnd.Next(1, 50)); // simulate doing work
            return ports;
        }

        public async Task<List<Port>> FindPorts(string country, bool? isDeepWater = null)
        {
            var ports = _portDb.Where(p => p.Country == country);
            if (isDeepWater.HasValue)
            {
                ports = ports.Where(p => p.IsDeepWater == isDeepWater.Value);
            }

            await Task.Delay(_rnd.Next(1, 50)); // simulate doing work

            return ports.Select(p => p.Clone()).ToList();
        }
    }
}
