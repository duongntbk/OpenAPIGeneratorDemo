using Microsoft.AspNetCore.Mvc;
using SampleApi.Models;
using SampleApi.Repositories;

namespace SampleApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AccountController : GenericController<Account>
    {
        public AccountController(IRepository<Account> repository)
            :base(repository)
        {
        }
    }
}
