using Microsoft.AspNetCore.Mvc;
using Pecunia.Models;
using Pecunia.Repositories;

namespace Pecunia.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : GenericController<Person>
    {
        public PersonController(IRepository<Person> personRepository)
            :base(personRepository)
        {
        }
    }
}
