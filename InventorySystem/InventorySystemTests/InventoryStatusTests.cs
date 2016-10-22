using BuinessLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace InventorySystem.Tests
{
    [TestClass()]
    public class InventoryStatusTests
    {
        List<Product> testProducts = new List<Product>();
      

        [TestMethod()]
        public void ProductAddedTest()
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
        public void ProductRemovedTest()
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
    }
}