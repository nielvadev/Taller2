using Microsoft.AspNetCore.Mvc;

namespace Taller2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        public static List<User> ListItem = new List<User>()
        {
            new User()
            {
                Name= "Juan",
                Id = 1,
                Address = "Calle 1",
                Phone = "123456789",
                BirthDate = DateTime.Now
            },
            new User()
            {
                Name= "Pedro",
                Id = 2,
                Address = "Calle 2",
                Phone = "123456789",
                BirthDate = DateTime.Now
            },
            new User()
            {
                Name= "Maria",
                Id = 3,
                Address = "Calle 3",
                Phone = "123456789",
                BirthDate = DateTime.Now
            },
        };


        [HttpGet(Name = "getUsers")]
        public IEnumerable<User> Get()
        {
            return ListItem;
        }       

    }

}

