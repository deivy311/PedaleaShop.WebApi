using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using PedaleaShop.Entities.Dtos;
using PedaleaShop.WebApi.Domain.Services.Interface;
using PedaleaShop.Entities.Extensions;
using System.Data;

namespace PedaleaShop.WebApi.Application.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUsersServices _servicesUser;
        private readonly IConfiguration _configuration;
        public UsersController(IUsersServices UserRepository)
        {
            this._servicesUser = UserRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserDto>>> GetItems()
        {
            try
            {

                IEnumerable<UserDto> Users = await this._servicesUser.GetEntities();

                if (Users == null)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(Users);
                }

            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                "Error retrieving data from the database");

            }
        }

        [HttpGet("{Id:int}")]
        public async Task<ActionResult<UserDto>> GetItem(int Id)
        {
            try
            {
                var User = await this._servicesUser.GetEntity(Id);

                if (User == null)
                {
                    return BadRequest();
                }
                else
                { 
                    return Ok(User);
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
        public async Task<ActionResult<IEnumerable<UserDto>>> GetItems(string userId)
        {
            try
            {
                var cartItems = await this._servicesUser.GetEntities(userId);

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

        [HttpPatch("UpdateQuantity/{userName}")]
        public async Task<ActionResult<UserDto>> UpdateQuantity(string userName, UserDto cartItemQuantityUpdateDto)
        {
            try
            {
                var cartItem = await this._servicesUser.UpdateEntittyQuantity(userName, cartItemQuantityUpdateDto);
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