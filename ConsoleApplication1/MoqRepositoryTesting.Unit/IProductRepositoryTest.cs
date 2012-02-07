using MoqRepositorySample;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Moq; 

namespace MoqRepositoryTesting.Unit
{
    
    
    /// <summary>
    ///This is a test class for IProductRepositoryTest and is intended
    ///to contain all IProductRepositoryTest Unit Tests
    ///</summary>
    [TestClass()]
    public class IProductRepositoryTest
    {

        public IProductRepositoryTest() 
        {
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
            mockProductRepository.Setup(mr => mr.findAll()).Returns(products);

            // return a product by Id
            mockProductRepository.Setup(mr => mr.findById(
                It.IsAny<int>())).Returns((int i) => products.Where(
                x => x.ProductId == i).Single());

            // return a product by Name
            mockProductRepository.Setup(mr => mr.findByName(
                It.IsAny<string>())).Returns((string s) => products.Where(
                x => x.Name == s).Single());

            // Allows us to test saving a product
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
 
                        original.Name = target.Name;
                        original.Price = target.Price;
                        original.Description = target.Description;
                        original.DateModified = now;
                    }
 
                    return true;
                });
 
            // Complete the setup of our Mock Product Repository
            //this.MockProductsRepository = mockProductRepository.Object;
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        internal virtual IProductRepository CreateIProductRepository()
        {
            // TODO: Instantiate an appropriate concrete class.
            IProductRepository target = null;
            return target;
        }

        /// <summary>
        ///A test for findAll
        ///</summary>
        [TestMethod()]
        public void findAllTest()
        {
            IProductRepository target = CreateIProductRepository(); // TODO: Initialize to an appropriate value
            IList<Product> expected = null; // TODO: Initialize to an appropriate value
            IList<Product> actual;
            actual = target.findAll();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for findById
        ///</summary>
        [TestMethod()]
        public void findByIdTest()
        {
            IProductRepository target = CreateIProductRepository(); // TODO: Initialize to an appropriate value
            int productId = 0; // TODO: Initialize to an appropriate value
            Product expected = null; // TODO: Initialize to an appropriate value
            Product actual;
            actual = target.findById(productId);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for findByName
        ///</summary>
        [TestMethod()]
        public void findByNameTest()
        {
            IProductRepository target = CreateIProductRepository(); // TODO: Initialize to an appropriate value
            string productName = string.Empty; // TODO: Initialize to an appropriate value
            Product expected = null; // TODO: Initialize to an appropriate value
            Product actual;
            actual = target.findByName(productName);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for save
        ///</summary>
        [TestMethod()]
        public void saveTest()
        {
            IProductRepository target = CreateIProductRepository(); // TODO: Initialize to an appropriate value
            Product target1 = null; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.save(target1);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
