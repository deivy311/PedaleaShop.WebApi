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
    public class ProductsCategoriesController : ControllerBase
    {
        private readonly IProductsCategoriesServices _servicesProductCategory;
        private readonly IConfiguration _configuration;
        public ProductsCategoriesController(IProductsCategoriesServices ProductCategoryRepository)
        {
            this._servicesProductCategory = ProductCategoryRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductCategoryDto>>> GetItems()
        {
            try
            {

                IEnumerable<ProductCategoryDto> ProductsCategories = await this._servicesProductCategory.GetEntities();

                if (ProductsCategories == null)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(ProductsCategories);
                }

            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                "Error retrieving data from the database");

            }
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<ProductCategoryDto>> GetItem(int id)
        {
            try
            {
                var ProductCategory = await this._servicesProductCategory.GetEntity(id);

                if (ProductCategory == null)
                {
                    return BadRequest();
                }
                else
                { 
                    return Ok(ProductCategory);
                }

            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                "Error retrieving data from the database");

            }
        }
    }
}