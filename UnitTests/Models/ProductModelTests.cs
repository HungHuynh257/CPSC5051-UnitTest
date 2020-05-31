using Microsoft.VisualStudio.TestTools.UnitTesting;
using HWUT.Models;
using System.Text.Json.Serialization;
using System.Text.Json;
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
            data.Ratings = null;

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
            data.Ratings = new int[] { 0, 0 };

            // Act
            var result = data.AverageRating();

            // Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void ProductModel_Get_Description_Default_Should_Return_Null()
        {
            // Arrange
            var data = new ProductModel();


            // Act
            var result = data.Description;

            // Assert
            Assert.IsNull(result);
        }

        [TestMethod]
        public void ProductModel_Get_Email_Default_Should_Return_Unknown()
        {
            // Arrange
            var data = new ProductModel();


            // Act
            var result = data.Email;

            // Assert
            Assert.AreEqual("Unknown", result);
        }

        [TestMethod]
        public void ProductModel_Get_Id_Default_Should_Return_Null()
        {
            // Arrange
            var data = new ProductModel();


            // Act
            var result = data.Id;

            // Assert
            Assert.IsNull(result);
        }

        [TestMethod]
        public void ProductModel_Get_Image_Default_Should_Return_Null()
        {
            // Arrange
            var data = new ProductModel();


            // Act
            var result = data.Image;

            // Assert
            Assert.IsNull(result);
        }

        [TestMethod]
        public void ProductModel_Get_Logistics_Default_Should_Return_Empty_String()
        {
            // Arrange
            var data = new ProductModel();


            // Act
            var result = data.Logistics;

            // Assert
            Assert.AreEqual("", result);
        }


        [TestMethod]
        public void ProductModel_Get_Maker_Default_Should_Return_Null()
        {
            // Arrange
            var data = new ProductModel();


            // Act
            var result = data.Maker;

            // Assert
            Assert.IsNull(result);
        }

        [TestMethod]
        public void ProductModel_Get_Sequence_Default_Should_Return_Null()
        {
            // Arrange
            var data = new ProductModel();


            // Act
            var result = data.Sequence;

            // Assert
            Assert.IsNull(result);
        }

        [TestMethod]
        public void ProductModel_Get_Title_Default_Should_Return_Null()
        {
            // Arrange
            var data = new ProductModel();


            // Act
            var result = data.Title;

            // Assert
            Assert.IsNull(result);
        }

        [TestMethod]
        public void ProductModel_Get_Url_Default_Should_Return_Null()
        {
            // Arrange
            var data = new ProductModel();


            // Act
            var result = data.Url;

            // Assert
            Assert.IsNull(result);
        }


        [TestMethod]
        public void ProductModel_Set_Description_To_String_hi_Should_Pass()
        {
            // Arrange
            var data = new ProductModel();


            // Act
            data.Description = "hi";

            // Assert
            Assert.AreEqual("hi", data.Description );
        }

        [TestMethod]
        public void ProductModel_Set_Id_To_String_hi_Should_Pass()
        {
            // Arrange
            var data = new ProductModel();


            // Act
            data.Id = "hi";

            // Assert
            Assert.AreEqual("hi", data.Id);
        }

        [TestMethod]
        public void ProductModel_Set_Image_To_String_hi_Should_Pass()
        {
            // Arrange
            var data = new ProductModel();


            // Act
            data.Image = "hi";

            // Assert
            Assert.AreEqual("hi", data.Image);
        }

        [TestMethod]
        public void ProductModel_Set_Maker_To_String_hi_Should_Pass()
        {
            // Arrange
            var data = new ProductModel();


            // Act
            data.Maker = "hi";

            // Assert
            Assert.AreEqual("hi", data.Maker);
        }

        [TestMethod]
        public void ProductModel_Set_Sequence_To_String_hi_Should_Pass()
        {
            // Arrange
            var data = new ProductModel();


            // Act
            data.Sequence = "hi";

            // Assert
            Assert.AreEqual("hi", data.Sequence);
        }

        [TestMethod]
        public void ProductModel_Set_Title_To_String_hi_Should_Pass()
        {
            // Arrange
            var data = new ProductModel();


            // Act
            data.Title = "hi";

            // Assert
            Assert.AreEqual("hi", data.Title);
        }


        [TestMethod]
        public void ProductModel_Set_Url_To_String_hi_Should_Pass()
        {
            // Arrange
            var data = new ProductModel();


            // Act
            data.Url = "hi";

            // Assert
            Assert.AreEqual("hi", data.Url);
        }

        [TestMethod]
        public void ProductModel_ToString_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual(JsonSerializer.Serialize<ProductModel>(result),result.ToString());
        }
    }

}
