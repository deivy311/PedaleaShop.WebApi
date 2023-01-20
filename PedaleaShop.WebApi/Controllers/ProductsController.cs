using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using PedaleaShop.WebApi.Domain.Entities.Dtos;
using PedaleaShop.WebApi.Domain.Services.Interface;
using PedaleaShop.WebApi.Domain.Extensions;
using System.Data;

namespace PedaleaShop.WebApi.Application.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductsServices _servicesProduct;
        private readonly IConfiguration _configuration;
        public ProductsController(IProductsServices productRepository)
        {
            this._servicesProduct = productRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductDto>>> GetItems()
        {
            try
            {

                IEnumerable<ProductDto> products = await this._servicesProduct.GetEntities();

                if (products == null)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(products);
                }

            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                "Error retrieving data from the database");

            }
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<ProductDto>> GetItem(int id)
        {
            try
            {
                var product = await this._servicesProduct.GetEntity(id);

                if (product == null)
                {
                    return BadRequest();
                }
                else
                { 
                    return Ok(product);
                }

            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                "Error retrieving data from the database");

            }
        }


        [HttpGet]
        [Route("{categoryId}/GetItemsByCategory")]
        public async Task<ActionResult<IEnumerable<ProductDto>>> GetItemsByCategory(int categoryId)
        {
            try
            {
                var products = await this._servicesProduct.GetEntitiesByCategory(categoryId);

                return Ok(products);

            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                "Error retrieving data from the database");
            }
        }
    }
}