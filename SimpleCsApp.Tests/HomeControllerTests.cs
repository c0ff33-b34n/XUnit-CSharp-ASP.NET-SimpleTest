using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using SimpleCsApp.Controllers;
using SimpleCsApp.Models;using Xunit;

namespace SimpleCsApp.Tests
{
    public class HomeControllerTests
    {
        [Fact]
        public void IndexActionModelIsComplete()
        {
            // Arrange
            var controller = new HomeController();
            Product[] products = new Product[] {
                new Product { Name = "Running Shoes", Price = 80M },
                new Product { Name = "Dumbell Weight Set", Price = 38M }
            };
            
            // Act
            var model = (controller.Index() as ViewResult)?.ViewData.Model 
                as IEnumerable<Product>;

            // Assert
            Assert.Equal(products, model,
                Comparer.Get<Product>((p1, p2) => p1.Name == p2.Name
                    && p1.Price == p2.Price));
        }
    }
}