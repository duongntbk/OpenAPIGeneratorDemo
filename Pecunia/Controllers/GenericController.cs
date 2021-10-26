using Microsoft.AspNetCore.Mvc;
using Pecunia.Models;
using Pecunia.Repositories;
using System;
using System.Threading.Tasks;

namespace Pecunia.Controllers
{
    public abstract class GenericController<T> : ControllerBase
        where T: class, ICloneable<T>, IFindable
    {
        private readonly IRepository<T> _repository;

        protected GenericController(IRepository<T> repository) =>
            _repository = repository;

        [HttpGet]
        [Route("show")]
        public async Task<IActionResult> ShowAsync([FromQuery] Guid uuid)
        {
            var record = await _repository.FindByUuid(uuid);
            if (record is object)
            {
                return Ok(record);
            }

            return NotFound($"Cannot find {typeof(T).Name} with Uuid: {uuid}");
        }

        [HttpGet]
        [Route("index")]
        public async Task<IActionResult> IndexAsync() => Ok(await _repository.FindAll());
    }
}
