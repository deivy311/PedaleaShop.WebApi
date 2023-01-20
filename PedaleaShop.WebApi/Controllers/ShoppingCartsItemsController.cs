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
    public class ShoppingCarstItemsController : ControllerBase
    {
        private readonly IShoppingCartsItemsServices _servicesShoppingCartItem;
        private readonly IConfiguration _configuration;
        public ShoppingCarstItemsController(IShoppingCartsItemsServices ShoppingCartItemRepository)
        {
            this._servicesShoppingCartItem = ShoppingCartItemRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ShoppingCartItemDto>>> GetItems()
        {
            try
            {

                IEnumerable<ShoppingCartItemDto> ShoppingCartsItems = await this._servicesShoppingCartItem.GetEntities();

                if (ShoppingCartsItems == null)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(ShoppingCartsItems);
                }

            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                "Error retrieving data from the database");

            }
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<ShoppingCartItemDto>> GetItem(int id)
        {
            try
            {
                var ShoppingCartItem = await this._servicesShoppingCartItem.GetEntity(id);

                if (ShoppingCartItem == null)
                {
                    return BadRequest();
                }
                else
                { 
                    return Ok(ShoppingCartItem);
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