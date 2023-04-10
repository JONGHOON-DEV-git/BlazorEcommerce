using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorEcommerce.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private static List<Product> Products = new List<Product>
        {
            new Product
            {
                Id = 1,
                Title = "Product 1",
                Description = "Learn how to build an E-Commerce Website with Blazor WebAssembly, a Web API, Entity Framework Core & SQL Server Express.\r\n정보\r\n스킬 수준: 중급자 수준",
                ImageUrl = "https://img.etoday.co.kr/pto_db/2018/03/20180315193124_1195576_600_818.jpg",
                Price = 10.99
            },
            new Product
            {
                Id = 2,
                Title = "Product 2",
                Description = "Description of product 2",
                ImageUrl = "https://th.bing.com/th/id/R.71bd73289c9ee6f1b33e6bdb48a9e73d?rik=N71yOrJSC4RcbA&riu=http%3a%2f%2ftalkimg.imbc.com%2fTVianUpload%2ftvian%2fTViews%2fimage%2f2020%2f03%2f04%2f2SOfCNas4QlQ637189111524986764.jpg&ehk=MYUhxIp5Qif1oISnTLQOzXTBDCZZGVtlV8f9XjDpnck%3d&risl=&pid=ImgRaw&r=0",
                Price = 20.99
            },
            new Product
            {
                Id = 3,
                Title = "Product 3",
                Description = "Description of product 3",
                ImageUrl = "https://2.bp.blogspot.com/-7Rbq14soFhw/XPz4hesPwZI/AAAAAAAAbq4/YQFrwlWXYQ09H7EQvjaejUWXOuUnNNIRACLcBGAs/s1600/img%2B%252810%2529.jpg",
                Price = 30.99
            },
            new Product
            {
                Id = 4,
                Title = "Product 4",
                Description = "Description of product 4",
                ImageUrl = "https://th.bing.com/th/id/R.772fbb7607037e6a9a0b1dd59fda92b9?rik=L5xnPMcMhZ98%2bw&riu=http%3a%2f%2fnewsroom.etomato.com%2fuserfiles%2fiu11.jpg&ehk=eWaqRAGRxFiwWoHe9fsjpBYwwewfsKYA5tU1FXgrA%2bo%3d&risl=&pid=ImgRaw&r=0",
                Price = 40.99
            },
            new Product
            {
                Id = 5,
                Title = "Product 5",
                Description = "Description of product 5",
                ImageUrl = "https://th.bing.com/th/id/OIP._nOo2HKL0yL5APK6BwbgXQHaKO?pid=ImgDet&rs=1",
                Price = 50.99
            }
        };

        [HttpGet]
        public async Task<IActionResult> GetProduct()
        {
            return Ok(Products);
        }
    }
}
