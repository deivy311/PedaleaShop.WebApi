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

        [HttpGet("{Id:int}")]
        public async Task<ActionResult<ShoppingCartItemDto>> GetItem(int Id)
        {
            try
            {
                var ShoppingCartItem = await this._servicesShoppingCartItem.GetEntity(Id);

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
        [HttpGet]
        [Route("{userId}/GetItems")]
        public async Task<ActionResult<IEnumerable<ShoppingCartItemDto>>> GetItems(string userId)
        {
            try
            {
                var cartItems = await this._servicesShoppingCartItem.GetEntities(userId);

                if (cartItems == null)
                {
                    return NoContent();
                }

                return Ok(cartItems);

            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);

            }
        }
        [HttpPost]
        public async Task<ActionResult<ShoppingCartItemDto>> PostItem([FromBody] ShoppingCartItemToAddDto cartItemToAddDto)
        {
            try
            {
                var newCartItem = await this._servicesShoppingCartItem.AddEntity(cartItemToAddDto);

                if (newCartItem == null)
                {
                    return NoContent();
                }


                return CreatedAtAction(nameof(GetItem), new { id = newCartItem.Id }, newCartItem);


            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
        [HttpDelete("{Id:int}")]
        public async Task<ActionResult<ShoppingCartItemDto>> DeleteItem(int Id)
        {
            try
            {
                var cartItem = await this._servicesShoppingCartItem.DeleteEntity(Id);

                if (cartItem == null)
                {
                    return NotFound();
                }

                 return Ok(cartItem);

            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
        [HttpPatch("{Id:int}")]
        public async Task<ActionResult<ShoppingCartItemDto>> UpdateQuantity(int Id, ShoppingCartItemQuantityUpdateDto cartItemQuantityUpdateDto)
        {
            try
            {
                var cartItem = await this._servicesShoppingCartItem.UpdateEntittyQuantity(Id, cartItemQuantityUpdateDto);
                if (cartItem == null)
                {
                    return NotFound();
                }

                return Ok(cartItem);

            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }

        }
    }
}