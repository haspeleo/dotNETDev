using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using MoqRepositorySample; 

namespace MoqRepositoryTests.Unit
{
    public class MoqRespositoryTests
    {

        public readonly IProductRepository MockProductsRepository; 

           // create some mock products to play with
            IList<Product> products = new List<Product>
                {
                    new Product { ProductId = 1, Name = "C# Unleashed",
                        Description = "Short description here", Price = 49.99 },
                    new Product { ProductId = 2, Name = "ASP.Net Unleashed",
                        Description = "Short description here", Price = 59.99 },
                    new Product { ProductId = 3, Name = "Silverlight Unleashed",
                        Description = "Short description here", Price = 29.99 }
                };
 
            // Mock the Products Repository using Moq
            Mock<IProductRepository> mockProductRepository = new Mock<IProductRepository>();

            // Return all the products
            mockProductRepository.Setup(mr => mr.FindAll()).Returns(products);

            // return a product by Id
            mockProductRepository.Setup(mr => mr.FindById(
                It.IsAny<int>())).Returns((int i) => products.Where(
                x => x.ProductId == i).Single());

            // return a product by Name
            mockProductRepository.Setup(mr => mr.FindByName(
                It.IsAny<string>())).Returns((string s) => products.Where(
                x => x.Name == s).Single());

            // Allows us to test saving a product
            mockProductRepository.Setup(mr => mr.Save(It.IsAny<Product>())).Returns(
                (Product target) =>
                {
                    DateTime now = DateTime.Now;
 
                    if (target.ProductId.Equals(default(int)))
                    {
                        target.DateCreated = now;
                        target.DateModified = now;
                        target.ProductId = products.Count() + 1;
                        products.Add(target);
                    }
                    else
                    {
                        var original = products.Where(
                            q => q.ProductId == target.ProductId).Single();
 
                        if (original == null)
                        {
                            return false;
                        }
 
                        original.Name = target.Name;
                        original.Price = target.Price;
                        original.Description = target.Description;
                        original.DateModified = now;
                    }
 
                    return true;
                });
 
            // Complete the setup of our Mock Product Repository
            this.MockProductsRepository = mockProductRepository.Object;
        }
        public MoqRespositoryTests ()
	    {

            //create some mock products to play with
            IList<Product> products = new List<Product> {
            
            new Product {ProductId = 1, Name = "C# unleashed", Description = "See Summary", Price = 49.99}, 
            new Product {ProductId = 2, Name = "ASP .NET", Description = "See Summary", Price = 19.99}, 
            new Product {ProductId = 3, Name = "Silverlight", Description = "See Summary", Price = 59.99}, 
            new Product {ProductId = 4, Name = "SQL Server", Description = "See Summary", Price = 69.99}
            };


            //Mock the product repository using Moq

            Mock<IProductRepository> mockProductRepository = new Mock<IProductRepository>();

            //Return All the  products
            mockProductRepository.Setup(mr => mr.findAll()).Returns(products);

            //Return a product by Id
            mockProductRepository.Setup(mr => mr.findById(
                It.IsAny<int>())).Returns((int i) => products.Where(
                x => x.ProductId == i).Single());

            //return a product by Name
            mockProductRepository.Setup(mr => mr.findByName(It.IsAny<string>()))
                .Returns((string s) => products.Where(x => x.Name == s).Single());
            //Allow us to save a product
            mockProductRepository.Setup(mr => mr.save(It.IsAny<Product>())).Returns(

                (Product target) =>
                {
                    DateTime now = DateTime.Now;
                    if (target.ProductId.Equals(default(int)))
                    {
                        target.DateCreated = now;
                        target.DateModified = now;
                        target.ProductId = products.Count() + 1;
                        products.Add(target);
                    }
                    else
                    {
                        var original = products.Where(
                            q => q.ProductId == target.ProductId).Single();
                        if (original == null)
                        {
                            return false;
                        }
                        else
                        {
                            original.Name = target.Name;
                            original.Price = target.Price;
                            original.Description = target.Description;
                            original.DateModified = now;
                        }

                    }
                    return true;
                }
            );

            // Complete the setup of our Mock Product Repository
            this.MockProductsRepository = mockProductRepository.Object;

        }

        

    }//class
}//namespace
