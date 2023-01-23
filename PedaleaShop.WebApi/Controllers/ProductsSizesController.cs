using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using PedaleaShop.Entities.Dtos;
using PedaleaShop.WebApi.Domain.Services.Interface;
using PedaleaShop.WebApi.Domain.Extensions;
using System.Data;

namespace PedaleaShop.WebApi.Application.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsSizesController : ControllerBase
    {
        private readonly IProductsSizesServices _servicesProductSize;
        private readonly IConfiguration _configuration;
        public ProductsSizesController(IProductsSizesServices ProductSizeRepository)
        {
            this._servicesProductSize = ProductSizeRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductsSizeDto>>> GetItems()
        {
            try
            {

                IEnumerable<ProductsSizeDto> ProductsSizes = await this._servicesProductSize.GetEntities();

                if (ProductsSizes == null)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(ProductsSizes);
                }

            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                "Error retrieving data from the database");

            }
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<ProductsSizeDto>> GetItem(int id)
        {
            try
            {
                var ProductSize = await this._servicesProductSize.GetEntity(id);

                if (ProductSize == null)
                {
                    return BadRequest();
                }
                else
                { 
                    return Ok(ProductSize);
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