using Microsoft.AspNetCore.Mvc;

namespace Taller2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        public static List<Product> ListItem = new List<Product>()
        {
            new Product()
            {
                Name= "Coca Cola",
                IdProd = 1,
                Price = 1700,
                State = true
            },
            new Product()
            {
                Name= "Pepsi",
                IdProd = 2,
                Price = 1200,
                State = true
            },
            new Product()
            {
                Name= "Fanta",
                IdProd = 3,
                Price = 1000,
                State = true
            }
        };

            [HttpGet(Name = "getProducts")]
            public IEnumerable<Product> Get()
            {
                return ListItem;
            }
        

    }

}

