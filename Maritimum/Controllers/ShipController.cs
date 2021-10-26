using Maritimum.Repositories;
using Maritimum.Requests;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Maritimum.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShipController : ControllerBase
    {
        private readonly IShipRepository _shipRepository;

        public ShipController(IShipRepository shipRepository) =>
            _shipRepository = shipRepository;

        [HttpPost]
        [Route("show")]
        public async Task<IActionResult> ShowAsync([FromBody] Guid uuid)
        {
            var ship = await _shipRepository.FindById(uuid);
            if (ship is object)
            {
                return Ok(ship);
            }

            return NotFound($"Cannot find Ship with Uuid: {uuid}");
        }

        [HttpPost]
        [Route("report")]
        public async Task<IActionResult>IndexAsync([FromBody] ShipReportRequest request) =>
                Ok(await _shipRepository.FindShips(request.HomePortUuid, request.MinTonnage, request.MaxTonnage));

        [HttpGet]
        [Route("index")]
        public async Task<IActionResult> ReportAsync() => Ok(await _shipRepository.FindAll());
    }
}
