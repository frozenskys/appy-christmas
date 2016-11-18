namespace ProductApi.Controllers
{
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Mvc;
    using ProductApi.Models;
    using System.Threading.Tasks;
    using Microsoft.EntityFrameworkCore;
    using System.Net;
    using Swashbuckle.SwaggerGen.Annotations;

    [Route("api/[controller]")]
    public class ProductsController : Controller
    {
        private readonly ProductContext _context;

        public ProductsController(ProductContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return _context.Products;
        }

        [Produces(typeof(Product))]
        [ProducesResponseType(typeof(Product), 200)]
        [ProducesResponseType(404)]
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {

            var product = await _context.Products.SingleOrDefaultAsync(p => p.ProductId == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
    }
}
