using Microsoft.AspNetCore.Mvc;
using SampleApi.Models;
using SampleApi.Repositories;

namespace SampleApi.Controllers
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
