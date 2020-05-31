using Microsoft.VisualStudio.TestTools.UnitTesting;
using HWUT.Models;
using System;

namespace UnitTests
{
    [TestClass]
    public class ProductModelTests
    {
        [TestMethod]
        public void ProductModel_Constructor_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ProductModel_Get_Date_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual(DateTime.UtcNow.ToShortDateString(), result.Date.ToShortDateString());
        }

        [TestMethod]
        public void ProductModel_AverageRating_Valid_Default_Should_Return_5()
        {
            // Arrange
            var data = new ProductModel();

            // Act
            var result = data.AverageRating();

            // Assert
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void ProductModel_AverageRating_NULL_Ratings_Should_Return_0()
        {
            // Arrange
            var data = new ProductModel();
            data.Ratings =  null;

            // Act
            var result = data.AverageRating();

            // Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void ProductModel_AverageRating_0_Count_Should_Return_0()
        {
            // Arrange
            var data = new ProductModel();
            data.Ratings = new int[] { };

            // Act
            var result = data.AverageRating();

            // Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void ProductModel_AverageRating_0_total_Should_Return_0()
        {
            // Arrange
            var data = new ProductModel();
            data.Ratings = new int[] {0,0};

            // Act
            var result = data.AverageRating();

            // Assert
            Assert.AreEqual(0, result);
        }
    }
}
