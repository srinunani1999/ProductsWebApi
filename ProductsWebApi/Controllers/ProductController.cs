using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductsWebApi.Models;

namespace ProductsWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private ProductsRepository productrepsitory;

        // GET: api/<ProductController>
        public ProductController(ProductsRepository productsRepository)
        {
            this.productrepsitory = productsRepository;
        }
        public IActionResult Get()
        {
            return Ok(productrepsitory.GetAll());
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var product = productrepsitory.Get(id);
            if (product == null)
            {
                return StatusCode(500);

            }
            return Ok(product);

        }
    }
}
