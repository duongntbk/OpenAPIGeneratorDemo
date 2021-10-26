using Pecunia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pecunia.Repositories
{
    public class Repository<T> : IRepository<T>
        where T : class, ICloneable<T>, IFindable
    {
        private readonly List<Person> _personDb;
        private readonly List<Account> _accountDb;
        private readonly Random _rnd;

        public Repository()
        {
            _personDb = new List<Person>
            {
                new Person
                {
                    Uuid = new Guid("dbf2a133-b342-4e22-8ef2-aab0ec249b08"),
                    Name = "John Doe",
                    Dob = new DateTime(1930, 2, 3)
                },
                new Person
                {
                    Uuid = new Guid("bccc5c8e-1248-4134-a07a-ed7c3b5ff9c1"),
                    Name = "Jane Doe",
                    Dob = new DateTime(1945, 9, 2)
                },
                new Person
                {
                    Uuid = new Guid("28c1b820-526f-4973-9f7b-4aa636eca22d"),
                    Name = "Tim Doe",
                },
                new Person
                {
                    Uuid = new Guid("e4b5e71e-74e6-4195-aab1-b61ff6ef42b3"),
                    Name = "Mary Doe",
                    Dob = new DateTime(1975, 4, 30)
                }
            };

            _accountDb = new List<Account>
            {
                new Account
                {
                    Uuid = new Guid("f1e6a450-04be-423d-9c73-516e196e0257"),
                    OwnerUuid = new Guid("dbf2a133-b342-4e22-8ef2-aab0ec249b08"),
                    Value = 1_000_000_000,
                    IsFrozen = false
                },
                new Account
                {
                    Uuid = new Guid("80b3bc37-8d7e-42ff-803a-73fecf08f51e"),
                    OwnerUuid = new Guid("dbf2a133-b342-4e22-8ef2-aab0ec249b08"),
                    Value = 2_000_000_000,
                    IsFrozen = false
                },
                new Account
                {
                    Uuid = new Guid("4335b7fa-e287-4166-a06b-b4cc95f5534a"),
                    OwnerUuid = new Guid("e4b5e71e-74e6-4195-aab1-b61ff6ef42b3"),
                    Value = 500_000_000,
                    IsFrozen = false
                },
                new Account
                {
                    Uuid = new Guid("f43a2cb2-3709-4f6a-b726-5c3bffa6a99f"),
                    OwnerUuid = new Guid("28c1b820-526f-4973-9f7b-4aa636eca22d"),
                    Value = 400_000_000,
                    IsFrozen = true
                },
                new Account
                {
                    Uuid = new Guid("c9b43814-6f33-4ef8-b368-811f4f75d575"),
                    OwnerUuid = new Guid("bccc5c8e-1248-4134-a07a-ed7c3b5ff9c1"),
                    Value = 1_400_000_000,
                    IsFrozen = true
                }
            };

            _rnd = new Random();
        }

        public async Task<List<T>> FindAll()
        {
            var db = GetDb();
            var allRecords = db.Select(p => p.Clone()).ToList();

            await Task.Delay(_rnd.Next(1,50)); // simulate doing work

            return allRecords;
        }

        public async Task<T> FindByUuid(Guid uuid)
        {
            var db = GetDb();
            var record = db.SingleOrDefault(p => p.Uuid == uuid);

            await Task.Delay(_rnd.Next(1, 50)); // simulate doing work

            return record?.Clone();
        }

        private List<T> GetDb()
        {
            if (typeof(T) == typeof(Person))
            {
                return _personDb as List<T>;
            }
            else if (typeof(T) == typeof(Account))
            {
                return _accountDb as List<T>;
            }

            throw new ArgumentException($"Cannot find repository for type: {typeof(T).Name}");
        }
    }
}
