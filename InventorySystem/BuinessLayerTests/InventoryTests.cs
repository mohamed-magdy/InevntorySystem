using BuinessLayerTests;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
namespace BuinessLayer.Tests
{
    [TestClass()]
    public class InventoryTests
    {
        List<Product> testProducts = new List<Product>();
        List<IObserverTest> testObservers = new List<IObserverTest>();
        [TestMethod()]
        public void AddProductTest()
        {
            Product product = new Product();
            product.Name = "Product 1";
            product.Description = "Product 1 is Added.";
            product.Qunatity = 2;
            product.Price = 18;
            product.AddedDate = DateTime.Now;
            testProducts.Add(product);

            Product expectedProduct = testProducts.LastOrDefault();
            Assert.AreEqual(product, expectedProduct);
        }

        [TestMethod()]
        public void RemoveProductTest()
        {
            Product product = new Product();
            product.Name = "Product 1";
            product.Description = "Product 1 is Removed.";
            product.Qunatity = 2;
            product.Price = 18;
            product.AddedDate = DateTime.Now;
            testProducts.Remove(product);

            Assert.IsFalse(testProducts.Contains(product));

        }

        [TestMethod()]
        public void AttachTest()
        {
            IObserverTest observer = null;
            int actualCount = testObservers.Count + 1;
            testObservers.Add(observer);
            Assert.AreEqual(testObservers.Count, actualCount);
        }

        [TestMethod()]
        public void DeattachTest()
        {
            IObserverTest observer = null;
            int actualCount = 0;
            if (testObservers.Count > 0)
                actualCount = testObservers.Count - 1;
            testObservers.Remove(observer);
            Assert.AreEqual(testObservers.Count, actualCount);
        }

        [TestMethod()]
        public void NotifyTest()
        {
            Product product1 = new Product();
            product1.Name = "Product 1";
            product1.Description = "Product 1 is Added.";
            product1.Qunatity = 2;
            product1.Price = 18;
            product1.AddedDate = DateTime.Now;

            Product product2 = new Product();
            product2.Name = "Product 2";
            product2.Description = "Product 1 is Removed.";
            product2.Qunatity = 2;
            product2.Price = 18;
            product2.AddedDate = DateTime.Now;

            IObserverTest observer = new ObserverTest();

            bool result = observer.ProductAdded(product1);


            bool result2 = observer.ProductRemoved(product2);

            Assert.IsTrue(result);
            Assert.IsTrue(result2);
        }

        [TestMethod()]
        public IQueryable<Product> ProductsTest()
        {
            IQueryable<Product> products = new List<Product>()
            {
                new Product() {Name ="Product1",Description="a new Product product1 is added",AddedDate=DateTime.Now,Price=18,Qunatity= 2},
                new Product() {Name ="Product2",Description="a new Product product2 is added",AddedDate=DateTime.Now,Price=20,Qunatity= 3 },
                new Product() {Name ="Product3",Description="a new Product product3 is added",AddedDate=DateTime.Now,Price=15,Qunatity= 5 }
            }.AsQueryable();

            return products;
        }
    }
}