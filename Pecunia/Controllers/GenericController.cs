using Microsoft.AspNetCore.Mvc;
using SampleApi.Models;
using SampleApi.Repositories;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SampleApi.Controllers
{
    public abstract class GenericController<T> : ControllerBase
        where T: class, ICloneable<T>, IFindable
    {
        private readonly IRepository<T> _repository;

        protected GenericController(IRepository<T> repository) =>
            _repository = repository;

        [HttpGet]
        [Route("show")]
        public async Task<T> ShowAsync(Guid uuid) => await _repository.FindByUuid(uuid);

        [HttpGet]
        [Route("index")]
        public async Task<List<T>> IndexAsync() => await _repository.FindAll();
    }
}
