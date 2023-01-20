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
    public class ProductsColorsController : ControllerBase
    {
        private readonly IProductsColorsServices _servicesProductColor;
        private readonly IConfiguration _configuration;
        public ProductsColorsController(IProductsColorsServices ProductColorRepository)
        {
            this._servicesProductColor = ProductColorRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductColorDto>>> GetItems()
        {
            try
            {

                IEnumerable<ProductColorDto> ProductsColors = await this._servicesProductColor.GetEntities();

                if (ProductsColors == null)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(ProductsColors);
                }

            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                "Error retrieving data from the database");

            }
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<ProductColorDto>> GetItem(int id)
        {
            try
            {
                var ProductColor = await this._servicesProductColor.GetEntity(id);

                if (ProductColor == null)
                {
                    return BadRequest();
                }
                else
                { 
                    return Ok(ProductColor);
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