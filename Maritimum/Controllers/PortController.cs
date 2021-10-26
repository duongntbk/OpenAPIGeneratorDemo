using Maritimum.Repositories;
using Maritimum.Requests;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Maritimum.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PortController : ControllerBase
    {
        private IPortRepository _portRepository;

        public PortController(IPortRepository portRepository) =>
            _portRepository = portRepository;

        [HttpPost]
        [Route("show")]
        public async Task<IActionResult> ShowAsync([FromBody] Guid uuid)
        {
            var port = await _portRepository.FindById(uuid);
            if (port is object)
            {
                return Ok(port);
            }

            return NotFound($"Cannot find Port with Uuid: {uuid}");
        }

        [HttpPost]
        [Route("report")]
        public async Task<IActionResult> IndexAsync([FromBody] PortReportRequest request) =>
                Ok(await _portRepository.FindPorts(request.Country, request.IsDeepWater));

        [HttpGet]
        [Route("index")]
        public async Task<IActionResult> ReportAsync() => Ok(await _portRepository.FindAll());
    }
}
