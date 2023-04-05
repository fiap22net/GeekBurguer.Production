using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GeekBurguer.Contracts;

namespace GeekBurguer.ProductionApi.Controllers
{
    [Route("api/[controller]")] 
    [Produces("application/json")]
    [ApiController]
    public class ProductionController : ControllerBase
    {
        private readonly List<Production> _list;

        public ProductionController()
        {
            _list = new List<Production>
            {
                new Production { ProductionId = 1111, Restrictions = new string[] { "soy", "dairy", "gluten", "sugar" }, On = true },
                new Production { ProductionId = 1112, Restrictions = new string[] { "soy" }, On = true },
                new Production { ProductionId = 1113, Restrictions = new string[] { "gluten" }, On = true },
                new Production { ProductionId = 1114, Restrictions = new string[] { }, On = true }
            };
        }

        [HttpGet("areas")]
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> GetAreas()
        {
            try
            {
                var result = await Task.FromResult(_list);
                return Ok(result);
            }
            catch { return StatusCode(500); }
        }

    }
}
