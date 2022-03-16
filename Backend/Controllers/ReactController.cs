using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ReactBackend.Data;
using ReactBackend.Models;
using ReactBackend.Models.DTO;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ReactBackend.Controllers
{
    [Route("api/[controller]")]
    public class ReactController : Controller
    {
        private readonly ReactDbContext _context;

        public ReactController(ReactDbContext context)
        {
            _context = context;
        }

        // GET: api/react
        [HttpGet]
        public string Get()
        {
            List<ProductModel> ProductModelsList = _context.ProductModels.ToList();
            List<SalesProduct> SalesProductsList = _context.SalesProducts.ToList();
            List<ProductDTO> ProductList = new List<ProductDTO>();
            foreach(SalesProduct salesItem in SalesProductsList)
            {
                ProductDTO Product = new ProductDTO();
                Product.Id = salesItem.Id;
                ProductModel productModel = ProductModelsList
                    .Where(p => p.Id == salesItem.Id)
                    .SingleOrDefault();
                Product.Name = productModel.Name;
                Product.Description = productModel.Description;
                Product.Price = salesItem.Price;
                Product.Stock = salesItem.Stock;
                ProductList.Add(Product);
            }

            string ReactList = JsonSerializer.Serialize(ProductList);

            return ReactList;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
