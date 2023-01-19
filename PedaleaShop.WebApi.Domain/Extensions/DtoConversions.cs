using PedaleaShop.WebApi.Domain.Entities;
using PedaleaShop.WebApi.Domain.Entities.Dtos;
using System.Data;

namespace PedaleaShop.WebApi.Domain.Extensions
{
    public static class DtoConversions
    {
        public static IEnumerable<ProductCategoryDto> ConvertToDto(this IEnumerable<Category> productCategories)
        {
            return (from productCategory in productCategories
                    select new ProductCategoryDto
                    {
                        Id = productCategory.Id,
                        Name = productCategory.Name,
                        IconCSS = productCategory.IconCSS
                    }).ToList();
        }
        //public static IEnumerable<ProductColor> ConvertToDto(this IEnumerable<Colors> productsColors)
        //{
        //    return (from productColor in productsColors
        //            select new ProductColor
        //            {
        //                Id = productColor.Id,
        //                Name = productColor.Name,
        //                IconCSS = productColor.IconCSS
        //            }).ToList();
        //}
        //public static IEnumerable<ProductSize> ConvertToDto(this IEnumerable<Size> productsSizes)
        //{
        //    return (from productSize in productsSizes
        //            select new ProductSize
        //            {
        //                Id = productSize.Id,
        //                Name = productSize.Name,
        //                IconCSS = productSize.IconCSS
        //            }).ToList();
        //}
        public static IEnumerable<ProductDto> ConvertToDto(this DataTable products)
        {
            return products.AsEnumerable().Select(row => new ProductDto
            {
                Id = Convert.ToInt32(row["Id"]),
                Name = Convert.ToString(row["Name"]),
                Description = Convert.ToString(row["Description"]),
                ImageURL = Convert.ToString(row["ImageURL"]),
                Price = Convert.ToDecimal(row["Price"]),
                Quantity = Convert.ToInt32(row["Quantity"]),
                CategoryId = Convert.ToInt32(row["CategoryId"]),
                ColorId = Convert.ToInt32(row["ColorId"]),
                SizeId = Convert.ToInt32(row["SizeId"]),
                CategoryName = Convert.ToString(row["CategoryName"]),
                ColorName = Convert.ToString(row["ColorName"]),
                SizeName = Convert.ToString(row["SizeName"])

            });
            //return (from product in products
            //        select new ProductDto
            //        {
            //            Id = product.Id,
            //            Name=product.Name,
            //            Description=product.Description,
            //            ImageURL=product.ImageURL,
            //            Price=product.Price,
            //            Quantity=product.Quantity,
            //            CategoryId= product.Category.Id,
            //            ColorId = product.Color.Id,
            //            SizeId = product.Size.Id,
            //            CategoryName = product.Category.Name,
            //            ColorName = product.Color.Name,
            //            SizeName = product.Size.Name
            //        }).ToList();

        }
        public static ProductDto ConvertToDto(this Product product)
                                                   
        {
            return new ProductDto
            {
                Id=product.Id,
                Name = product.Name,
                Description = product.Description,
                ImageURL = product.ImageURL,
                Price = product.Price,
                Quantity = product.Quantity,
                CategoryId = product.Category.Id,
                ColorId= product.Color.Id,
                SizeId= product.Size.Id,
                CategoryName = product.Category.Name,
                ColorName= product.Color.Name,
                SizeName= product.Size.Name
            };

        }

        public static IEnumerable<CartItemDto> ConvertToDto(this IEnumerable<ShoppingCartItem> cartItems,
                                                            IEnumerable<Product> products)
        {
            return (from cartItem in cartItems
                    join product in products
                    on cartItem.ProductId equals product.Id
                    select new CartItemDto
                    {
                        Id = cartItem.Id,
                        ProductId = cartItem.ProductId,
                        ProductName = product.Name,
                        ProductDescription = product.Description,
                        ProductImageURL = product.ImageURL,
                        Price = product.Price,
                        CartId = cartItem.ShoppingCartId,
                        Quantity = cartItem.Quantity,
                        TotalPrice = product.Price * cartItem.Quantity
                    }).ToList();
        }
        public static CartItemDto ConvertToDto(this ShoppingCartItem cartItem,
                                                    Product product)
        {
            return new CartItemDto
                 {
                     Id = cartItem.Id,
                     ProductId = cartItem.ProductId,
                     ProductName = product.Name,
                     ProductDescription = product.Description,
                     ProductImageURL = product.ImageURL,
                     Price = product.Price,
                     CartId = cartItem.ShoppingCartId,
                     Quantity = cartItem.Quantity,
                     TotalPrice = product.Price * cartItem.Quantity
                 };
        }

    }
}
