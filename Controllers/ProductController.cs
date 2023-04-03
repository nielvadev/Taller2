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
            },
            new Product()
            {
                Name = "Sprite",
                IdProd = 4,
                Price = 800,
                State = false
            },
            new Product()
            {
                Name= "Manzana",
                IdProd = 5,
                Price = 700,
                State = true
            },

        };

        [HttpGet(Name = "getProducts")]
        public IEnumerable<Product> Get()
        {
            return ListItem;
        }

        [HttpGet("Item")]
        public Product GetItem(int id)
        {
            var item = ListItem.Where(x => x.IdProd == id).ToList();
            if (item.Count > 0)
            {
                return item[0];
            }
            else
            {
                return new Product()
                {
                    Name = "N/A",
                    IdProd = 0,
                    Price = 0,
                    State = false
                };
            }
        }

        [HttpGet("Detail")]
        public dynamic Detail(int id)
        {
            var token = Request.Headers.Where(x => x.Key.Equals("token")).FirstOrDefault();

            if (token.Value.Count == 0)
            {
                return new
                {
                    code = "API ERROR",
                    message = "Not authorized",
                    Detail = "N/A"
                };
            }
            else
            {
                if (token.Value != "x1234")
                {
                    return new
                    {
                        code = "API ERROR",
                        message = "Invalid Key",
                        Detail = "N/A"
                    };
                }
            }

            var item = ListItem.Where(x => x.IdProd == id).ToList();
            if (item.Count > 0)
            {
                if (id == 0)
                {
                    return new
                    {
                        code = "API SUCCESS",
                        message = "OK",
                        Detail = item
                    };
                }
                else
                {
                    return item;
                }
            }
            else
            {
                return new
                {
                    code = "API COUNT",
                    message = "EMPTY ID",
                    Detail = "N/A"
                };
            }
        }

        

    }

}

