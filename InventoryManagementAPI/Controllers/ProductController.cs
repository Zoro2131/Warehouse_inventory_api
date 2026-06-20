using InventoryManagementAPI.Models;
using Microsoft.AspNetCore.Mvc;
using InventoryManagementAPI.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace InventoryManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        //this is the constructor for the product controller,
        //it will initialize the _products field with the sample data set
        private readonly List<ProductDefinition> _products;
        public ProductController()
        {
            _products = SampleDataSet.GetSampleProducts();
        }

        // GET: api/<ProductController>
        //get all the products
        [HttpGet]
        public List <ProductDefinition> GetAllProducts()
        {
            var products = _products;
            return products;
        }

        // GET api/<ProductController>
        //Gets an item by the id
        [HttpGet("id")]
        public ProductDefinition GetProductById(int id)
        {

            foreach (var product in _products)
            {
                if(product.Id == id){
                    return product;
                }
            }
            Console.WriteLine("No Item found with that Id");
            return null;
        }

        // Get api/<ProductController>
        // Get by product Name
        [HttpGet("name")]
        public ProductDefinition GetProductByName(string name)
        {
            foreach (var product in _products)
            {
                if(product.Name == name)
                {
                    return product;
                }
            }
            Console.WriteLine("No Item found with that Name");
            return null;
        }

        // Get api/<ProductController>
        // Get by product list if it IsFerrous
        [HttpGet("ferrous")]
        public List <ProductDefinition> GetProductsIsFerrous()
        {
            List <ProductDefinition> products = new List<ProductDefinition>();
            foreach (var product in _products)
            {
                if (product.IsFerrous == true)
                {
                    products.Add(product); 
                }
            }
            if(products.Count == 0)
            {
                //will need to remove or update later when i call the 
                Console.WriteLine("No ferrous products found");
            }
            return products;

        }

        // Get api/<ProductController>
        // Get by product List by grade
        [HttpGet("Grade")]
        public List<ProductDefinition> GetProductsByGrade(string grade)
        {
            List<ProductDefinition> products = new List<ProductDefinition>();
            foreach (var product in _products)
            {
                if (product.Grade == grade)
                {
                    products.Add(product);
                }
            }
            if (products.Count == 0)
            {
                //will need to remove or update later when i call the 
                Console.WriteLine("No products with that grade found");
            }
            return products;
        }

        // POST api/<ProductController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
            //If name is empty - reject
            //if weight/lenght. height, width are empty - reject
            //if grade is empty set to unkown
            //ferrous should be set this is a testable element

            //Work flow steps
            //Recive ProductionDeginition
            //Validate Name 
            //validate Dimensions
            //validate weight
            //Set grade to unkown if input is empty 
            //generate new id for the item
            //add to _products list 
            //return success msg to the user 
        }

        // PUT api/<ProductController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
