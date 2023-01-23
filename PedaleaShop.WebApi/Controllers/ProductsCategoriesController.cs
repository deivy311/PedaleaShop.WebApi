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

        //[HttpGet]
        //[Route(nameof(GetProductCategories))]
        //public async Task<ActionResult<IEnumerable<ProductCategoryDto>>> GetProductCategories()
        //{
        //    try
        //    {
        //        var productCategories = await _servicesProduct.GetCategories();

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
        //public async Task<ActionResult<IEnumerable<ProductsDto>>> GetItemsByCategory(int categoryId)
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