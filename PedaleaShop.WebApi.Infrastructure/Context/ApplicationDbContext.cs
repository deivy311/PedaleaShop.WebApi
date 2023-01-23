using Microsoft.EntityFrameworkCore;
using PedaleaShop.Entities.Dtos;
using PedaleaShop.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace PedaleaShop.WebApi.Infrastructure.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

			protected override void OnModelCreating(ModelBuilder modelBuilder)
			{
				base.OnModelCreating(modelBuilder);
				//Products
				//Beauty Category
				modelBuilder.Entity<Product>().HasData(new Product
				{
					Id = 1,
					Name = "Glossier - Beauty Kit",
					Description = "A kit provided by Glossier, containing skin care, hair care and makeup products",
					ImageURL = "/Images/Beauty/Beauty1.png",
					Price = 100,
					Quantity = 100,
					ColorId = 1,
					SizeId = 1,
					CategoryId = 1

				});
				modelBuilder.Entity<Product>().HasData(new Product
				{
					Id = 2,
					Name = "Curology - Skin Care Kit",
					Description = "A kit provided by Curology, containing skin care products",
					ImageURL = "/Images/Beauty/Beauty2.png",
					Price = 50,
					Quantity = 45,
					ColorId = 2,
					SizeId = 1,
					CategoryId = 1

				});
				modelBuilder.Entity<Product>().HasData(new Product
				{
					Id = 3,
					Name = "Cocooil - Organic Coconut Oil",
					Description = "A kit provided by Curology, containing skin care products",
					ImageURL = "/Images/Beauty/Beauty3.png",
					Price = 20,
					Quantity = 30,
					ColorId = 3,
					SizeId = 2,
					CategoryId = 1

				});
				modelBuilder.Entity<Product>().HasData(new Product
				{
					Id = 4,
					Name = "Schwarzkopf - Hair Care and Skin Care Kit",
					Description = "A kit provided by Schwarzkopf, containing skin care and hair care products",
					ImageURL = "/Images/Beauty/Beauty4.png",
					Price = 50,
					Quantity = 60,
					ColorId = 1,
					SizeId = 3,
					CategoryId = 1

				});
				modelBuilder.Entity<Product>().HasData(new Product
				{
					Id = 5,
					Name = "Skin Care Kit",
					Description = "Skin Care Kit, containing skin care and hair care products",
					ImageURL = "/Images/Beauty/Beauty5.png",
					Price = 30,
					Quantity = 85,
					ColorId = 2,
					SizeId = 2,
					CategoryId = 1

				});
				modelBuilder.Entity<AspNetUsers>().HasData(new AspNetUsers
				{
					// Id = "1",
					// UserName = "davidestebanimbajoa@gmail.com"
					Id = "149ab3f6-90c5-4d75-9869-7ac39b3e97d9",
					UserName = "davidestebanimbajoa@gmail.com",
					NormalizedUserName = "davidestebanimbajoa@gmail.com",
					Email = "davidestebanimbajoa@gmail.com",
					NormalizedEmail = "davidestebanimbajoa@gmail.com",
					EmailConfirmed = true,
					//Password: UserTest1,.
					PasswordHash = "AQAAAAEAACcQAAAAEMETj55V93QAGz/VUC+mh0aSHZpTsjs/iDCPl9gb3WfR5Hh37e4lpqA0jcXUqXJVXA==",
					SecurityStamp = "MF25UIELSTRYUTJ6BBZBKZNHQISDIKSY",
					ConcurrencyStamp = "27fb2476-a45f-43e3-a5c8-7e229fd823ee",
					PhoneNumber = "313",
					PhoneNumberConfirmed = false,
					TwoFactorEnabled = false,
					//LockoutEnd = NULL,
					LockoutEnabled = true,
					AccessFailedCount = 0

				});
				//Electronics Category
				modelBuilder.Entity<Product>().HasData(new Product
				{
					Id = 6,
					Name = "Air Pods",
					Description = "Air Pods - in-ear wireless headphones",
					ImageURL = "/Images/Electronic/Electronics1.png",
					Price = 100,
					Quantity = 120,
					ColorId = 1,
					SizeId = 2,
					CategoryId = 3

				});
				modelBuilder.Entity<Product>().HasData(new Product
				{
					Id = 7,
					Name = "On-ear Golden Headphones",
					Description = "On-ear Golden Headphones - these headphones are not wireless",
					ImageURL = "/Images/Electronic/Electronics2.png",
					Price = 40,
					Quantity = 200,
					ColorId = 3,
					SizeId = 1,
					CategoryId = 3

				});
				modelBuilder.Entity<Product>().HasData(new Product
				{
					Id = 8,
					Name = "On-ear Black Headphones",
					Description = "On-ear Black Headphones - these headphones are not wireless",
					ImageURL = "/Images/Electronic/Electronics3.png",
					Price = 40,
					Quantity = 300,
					ColorId = 2,
					SizeId = 3,
					CategoryId = 3

				});
				modelBuilder.Entity<Product>().HasData(new Product
				{
					Id = 9,
					Name = "Sennheiser Digital Camera with Tripod",
					Description = "Sennheiser Digital Camera - High quality digital camera provided by Sennheiser - includes tripod",
					ImageURL = "/Images/Electronic/Electronic4.png",
					Price = 600,
					Quantity = 20,
					ColorId = 1,
					SizeId = 4,
					CategoryId = 3

				});
				modelBuilder.Entity<Product>().HasData(new Product
				{
					Id = 10,
					Name = "Canon Digital Camera",
					Description = "Canon Digital Camera - High quality digital camera provided by Canon",
					ImageURL = "/Images/Electronic/Electronic5.png",
					Price = 500,
					Quantity = 15,
					ColorId = 3,
					SizeId = 5,
					CategoryId = 3

				});
				modelBuilder.Entity<Product>().HasData(new Product
				{
					Id = 11,
					Name = "Nintendo Gameboy",
					Description = "Gameboy - Provided by Nintendo",
					ImageURL = "/Images/Electronic/technology6.png",
					Price = 100,
					Quantity = 60,
					ColorId = 3,
					SizeId = 5,
					CategoryId = 3
				});
				//Furniture Category
				modelBuilder.Entity<Product>().HasData(new Product
				{
					Id = 12,
					Name = "Black Leather Office Chair",
					Description = "Very comfortable black leather office chair",
					ImageURL = "/Images/Furniture/Furniture1.png",
					Price = 50,
					Quantity = 212,
					ColorId = 1,
					SizeId = 5,
					CategoryId = 2
				});

				modelBuilder.Entity<Product>().HasData(new Product
				{
					Id = 13,
					Name = "Pink Leather Office Chair",
					Description = "Very comfortable pink leather office chair",
					ImageURL = "/Images/Furniture/Furniture2.png",
					Price = 50,
					Quantity = 112,
					ColorId = 2,
					SizeId = 1,
					CategoryId = 2
				});
				modelBuilder.Entity<Product>().HasData(new Product
				{
					Id = 14,
					Name = "Lounge Chair",
					Description = "Very comfortable lounge chair",
					ImageURL = "/Images/Furniture/Furniture3.png",
					Price = 70,
					Quantity = 90,
					ColorId = 1,
					SizeId = 4,
					CategoryId = 2
				});
				modelBuilder.Entity<Product>().HasData(new Product
				{
					Id = 15,
					Name = "Silver Lounge Chair",
					Description = "Very comfortable Silver lounge chair",
					ImageURL = "/Images/Furniture/Furniture4.png",
					Price = 120,
					Quantity = 95,
					ColorId = 1,
					SizeId = 3,
					CategoryId = 2
				});
				modelBuilder.Entity<Product>().HasData(new Product
				{
					Id = 16,
					Name = "Porcelain Table Lamp",
					Description = "White and blue Porcelain Table Lamp",
					ImageURL = "/Images/Furniture/Furniture6.png",
					Price = 15,
					Quantity = 100,
					ColorId = 2,
					SizeId = 2,
					CategoryId = 2
				});
				modelBuilder.Entity<Product>().HasData(new Product
				{
					Id = 17,
					Name = "Office Table Lamp",
					Description = "Office Table Lamp",
					ImageURL = "/Images/Furniture/Furniture7.png",
					Price = 20,
					Quantity = 73,
					ColorId = 1,
					SizeId = 1,
					CategoryId = 2
				});
				//Shoes Category
				modelBuilder.Entity<Product>().HasData(new Product
				{
					Id = 18,
					Name = "Puma Sneakers",
					Description = "Comfortable Puma Sneakers in most sizes",
					ImageURL = "/Images/Shoes/Shoes1.png",
					Price = 100,
					Quantity = 50,
					ColorId = 3,
					SizeId = 2,
					CategoryId = 4
				});
				modelBuilder.Entity<Product>().HasData(new Product
				{
					Id = 19,
					Name = "Colorful Trainers",
					Description = "Colorful trainsers - available in most sizes",
					ImageURL = "/Images/Shoes/Shoes2.png",
					Price = 150,
					Quantity = 60,
					ColorId = 1,
					SizeId = 4,
					CategoryId = 4
				});
				modelBuilder.Entity<Product>().HasData(new Product
				{
					Id = 20,
					Name = "Blue Nike Trainers",
					Description = "Blue Nike Trainers - available in most sizes",
					ImageURL = "/Images/Shoes/Shoes3.png",
					Price = 200,
					Quantity = 70,
					ColorId = 2,
					SizeId = 3,
					CategoryId = 4
				});
				modelBuilder.Entity<Product>().HasData(new Product
				{
					Id = 21,
					Name = "Colorful Hummel Trainers",
					Description = "Colorful Hummel Trainers - available in most sizes",
					ImageURL = "/Images/Shoes/Shoes4.png",
					Price = 120,
					Quantity = 120,
					ColorId = 1,
					SizeId = 5,
					CategoryId = 4
				});
				modelBuilder.Entity<Product>().HasData(new Product
				{
					Id = 22,
					Name = "Red Nike Trainers",
					Description = "Red Nike Trainers - available in most sizes",
					ImageURL = "/Images/Shoes/Shoes5.png",
					Price = 200,
					Quantity = 100,
					ColorId = 1,
					SizeId = 2,
					CategoryId = 4
				});
				modelBuilder.Entity<Product>().HasData(new Product
				{
					Id = 23,
					Name = "Birkenstock Sandles",
					Description = "Birkenstock Sandles - available in most sizes",
					ImageURL = "/Images/Shoes/Shoes6.png",
					Price = 50,
					Quantity = 150,
					ColorId = 3,
					SizeId = 3,
					CategoryId = 4
				});

				//Add users



				//Create Shopping Cart for Users
				modelBuilder.Entity<ShoppingCart>().HasData(new ShoppingCart
				{
					Id = 1,
					UserId = "149ab3f6-90c5-4d75-9869-7ac39b3e97d9"

				});

				//Add Product Categories
				modelBuilder.Entity<Category>().HasData(new Category
				{
					Id = 1,
					Name = "Beauty",
					IconCSS = "fas fa-spa"
				});
				modelBuilder.Entity<Category>().HasData(new Category
				{
					Id = 2,
					Name = "Furniture",
					IconCSS = "fas fa-couch"
				});
				modelBuilder.Entity<Category>().HasData(new Category
				{
					Id = 3,
					Name = "Electronics",
					IconCSS = "fas fa-headphones"
				});
				modelBuilder.Entity<Category>().HasData(new Category
				{
					Id = 4,
					Name = "Shoes",
					IconCSS = "fas fa-shoe-prints"
				});


				//Adding product colors
				modelBuilder.Entity<Colors>().HasData(new Colors
				{
					Id = 1,
					Name = "Red",
					IconCSS = "fas fa-shoe-prints"
				});

				modelBuilder.Entity<Colors>().HasData(new Colors
				{
					Id = 2,
					Name = "Green",
					IconCSS = "fas fa-shoe-prints"
				});

				modelBuilder.Entity<Colors>().HasData(new Colors
				{
					Id = 3,
					Name = "Blue",
					IconCSS = "fas fa-shoe-prints"
				});

				//Adding product sizes 
				modelBuilder.Entity<Size>().HasData(new Size
				{
					Id = 1,
					Name = "XS",
					IconCSS = "fas fa-shoe-prints"
				});
				modelBuilder.Entity<Size>().HasData(new Size
				{
					Id = 2,
					Name = "S",
					IconCSS = "fas fa-shoe-prints"
				});
				modelBuilder.Entity<Size>().HasData(new Size
				{
					Id = 3,
					Name = "M",
					IconCSS = "fas fa-shoe-prints"
				});
				modelBuilder.Entity<Size>().HasData(new Size
				{
					Id = 4,
					Name = "L",
					IconCSS = "fas fa-shoe-prints"
				});
				modelBuilder.Entity<Size>().HasData(new Size
				{
					Id = 5,
					Name = "XL",
					IconCSS = "fas fa-shoe-prints"
				});
				modelBuilder.Entity<Size>().HasData(new Size
				{
					Id = 6,
					Name = "XXL",
					IconCSS = "fas fa-shoe-prints"
				});
				modelBuilder.Entity<AspNetUserLogins>()
			  .HasKey(m => new { m.LoginProvider, m.ProviderKey });
			}
		//Dtos
		public DbSet<ProductsDto> ProductsDto { get; set; }
		public DbSet<ShoppingCart> ShoppingCarts { get; set; }
			public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
			public DbSet<Product> Products { get; set; }
			public DbSet<Category> Categories { get; set; }
			public DbSet<Size> Sizes { get; set; }
			public DbSet<Colors> Colors { get; set; }
			public DbSet<SeparatePlans> SeparatePlans { get; set; }
			//public DbSet<AspNetRoleClaims> AspNetRoleClaims { get; set; }
			//      public DbSet<AspNetRoles> AspNetRoles { get; set; }
			//      public DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
			//public DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
			//public DbSet<AspNetUsers> AspNetUsers { get; set; }
			//public DbSet<AspNetUserTokens> AspNetUserTokens { get; set; }
			//public DbSet<DeviceCodes> DeviceCodes { get; set; }
			//public DbSet<Keys> Keys { get; set; }
			//public DbSet<PersistedGrants> PersistedGrants { get; set; }
			//public virtual int SeparatePlanInsert(string userName, Nullable<int> cartId)
			//{
			//	//var userNameParameter = userName != null ?
			//	//	new ObjectParameter("UserName", userName) :
			//	//	new ObjectParameter("UserName", typeof(string));

			//	//var cartIdParameter = cartId.HasValue ?
			//	//	new ObjectParameter("CartId", cartId) :
			//	//	new ObjectParameter("CartId", typeof(int));

			//	return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SeparatePlanInsert", userName, cartId);
			//}
		}
	}
