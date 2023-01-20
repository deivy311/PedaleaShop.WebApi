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
        //public ProductsController(IConfiguration configuration)
        //{
        //    this._configuration = configuration;
        //}
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
        //[HttpGet("{id:int}")]
        //public async Task<ActionResult<ProductDto>> GetItem(int id)
        //{
        //    try
        //    {
        //        var product = await this.productRepository.GetProduct(id);

        //        if (product == null)
        //        {
        //            return BadRequest();
        //        }
        //        else
        //        {

        //            var productDto = product.ConvertToDto();

        //            return Ok(productDto);
        //        }

        //    }
        //    catch (Exception)
        //    {
        //        return StatusCode(StatusCodes.Status500InternalServerError,
        //                        "Error retrieving data from the database");

        //    }
        //}

        //[HttpGet]
        //[Route(nameof(GetProductCategories))]
        //public async Task<ActionResult<IEnumerable<ProductCategoryDto>>> GetProductCategories()
        //{
        //    try
        //    {
        //        var productCategories = await productRepository.GetCategories();

        //        var productCategoryDtos = productCategories.ConvertToDto();

        //        return Ok(productCategoryDtos);

        //    }
        //    catch (Exception)
        //    {
        //        return StatusCode(StatusCodes.Status500InternalServerError,
        //                        "Error retrieving data from the database");
        //    }

        //}
        //[HttpGet]
        //[Route(nameof(GetProductsColors))]
        //public async Task<ActionResult<IEnumerable<ProductColor>>> GetProductsColors()
        //{
        //    try
        //    {
        //        var productColors = await productRepository.GetColors();

        //        var productColor = productColors.ConvertToDto();

        //        return Ok(productColor);

        //    }
        //    catch (Exception)
        //    {
        //        return StatusCode(StatusCodes.Status500InternalServerError,
        //                        "Error retrieving data from the database");
        //    }

        //}
        //[HttpGet]
        //[Route(nameof(GetProductsSizes))]
        //public async Task<ActionResult<IEnumerable<ProductColor>>> GetProductsSizes()
        //{
        //    try
        //    {
        //        var productSizess = await productRepository.GetSizes();

        //        var productSize = productSizess.ConvertToDto();

        //        return Ok(productSize);

        //    }
        //    catch (Exception)
        //    {
        //        return StatusCode(StatusCodes.Status500InternalServerError,
        //                        "Error retrieving data from the database");
        //    }

        //}

        //[HttpGet]
        //[Route("{categoryId}/GetItemsByCategory")]
        //public async Task<ActionResult<IEnumerable<ProductDto>>> GetItemsByCategory(int categoryId)
        //{
        //    try
        //    {
        //        var products = await productRepository.GetProdutsByCategory(categoryId);

        //        var productDtos = products.ConvertToDto();

        //        return Ok(productDtos);

        //    }
        //    catch (Exception)
        //    {
        //        return StatusCode(StatusCodes.Status500InternalServerError,
        //                        "Error retrieving data from the database");
        //    }
        //}
    }
}