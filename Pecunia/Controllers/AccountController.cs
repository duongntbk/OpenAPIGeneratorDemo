using Microsoft.AspNetCore.Mvc;
using Pecunia.Models;
using Pecunia.Repositories;

namespace Pecunia.Controllers
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
