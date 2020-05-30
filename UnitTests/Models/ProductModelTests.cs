using Microsoft.VisualStudio.TestTools.UnitTesting;
using HWUT.Models;
using System;
using System.Text.Json;
using Microsoft.VisualBasic;

namespace UnitTests
{
    [TestClass]
    public class ProductModelTests
    {
        [TestMethod]
        public void ProductModel_Get_Set_Id_Default_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();

            // Assert
            Assert.IsNull(result.Id);

            // Act
            result.Id = "123";

            // Assert
            Assert.AreEqual("123", result.Id);
        }

        [TestMethod]
        public void ProductModel_Get_Set_Maker_Default_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();

            // Assert
            Assert.IsNull(result.Maker);

            // Act
            result.Maker = "Bob";

            // Assert
            Assert.AreEqual("Bob", result.Maker);
        }

        [TestMethod]
        public void ProductModel_Get_Set_Image_Default_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();

            //Assert
            Assert.IsNull(result.Image);
            
            // Act
            result.Image = "cat.jpg";

            // Assert
            Assert.AreEqual("cat.jpg", result.Image);
        }

        [TestMethod]
        public void ProductModel_Get_Set_Url_Default_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();

            //Assert
            Assert.IsNull(result.Url);

            // Act
            result.Url = "http://www.google.com";

            // Assert
            Assert.AreEqual("http://www.google.com", result.Url);
        }

        [TestMethod]
        public void ProductModel_Get_Set_Title_Default_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();

            //Assert
            Assert.IsNull(result.Title);

            // Act
            result.Title = "A cat in a hat";

            // Assert
            Assert.AreEqual("A cat in a hat", result.Title);
        }

        [TestMethod]
        public void ProductModel_Get_Set_Description_Default_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();

            // Assert
            Assert.IsNull(result.Description);

            // Act
            result.Description = "This item is nice.";

            // Assert
            Assert.AreEqual("This item is nice.", result.Description);
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
        public void ProductModel_Set_Date_Default_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();
            DateTime myDate = DateTime.Parse("5/29/2020 8:24:00 PM");
            
            // Act
            result.Date = myDate;

            // Assert
            Assert.AreEqual(myDate, result.Date);
        }

        [TestMethod]
        public void ProductModel_Get_Set_Sequence_Default_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();

            // Assert
            Assert.IsNull(result.Sequence);

            // Act
            result.Sequence = "Montreal";

            // Assert
            Assert.AreEqual("Montreal", result.Sequence);
        }

        [TestMethod]
        public void ProductModel_Get_Email_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual("Unknown", result.Email);
        }

        [TestMethod]
        public void ProductModel_Set_Email_Default_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Email = "person@domain.com";

            // Assert
            Assert.AreEqual("person@domain.com", result.Email);
        }

        [TestMethod]
        public void ProductModel_Get_Logistics_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual("", result.Logistics);
        }

        [TestMethod]
        public void ProductModel_Set_Logistics_Default_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Logistics = "PIGT209";

            // Assert
            Assert.AreEqual("PIGT209", result.Logistics);
        }

        [TestMethod]
        public void ProductModel_Get_Ratings_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.IsNotNull(result.Ratings);
            Assert.AreEqual(1, result.Ratings.Length);
            Assert.AreEqual(5, result.Ratings[0]);
        }

        [TestMethod]
        public void ProductModel_Set_Ratings_Default_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Ratings[0] = 2;

            // Assert
            Assert.AreEqual(2, result.Ratings[0]);
        }

        [TestMethod]
        public void ProductModel_toString_Default_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();
            var myDate = "2020-05-05T00:00:00";
            result.Date = DateTime.Parse(myDate);
            var expected = "{\"Id\":null,\"Maker\":null,\"img\":null,\"Url\":null,\"Title\":null"
               + ",\"Description\":null,\"Date\":\""
               + myDate
               + "\",\"Sequence\":null,\"Email\":\"Unknown\",\"Logistics\":\"\",\"Ratings\":[5]}";

            // Act
            var actual = result.ToString();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ProductModel_Constructor_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.IsNotNull(result);
            Assert.IsNull(result.Id);
            Assert.IsNull(result.Maker);
            Assert.IsNull(result.Image);
            Assert.IsNull(result.Url);
            Assert.IsNull(result.Title);
            Assert.IsNull(result.Description);
            Assert.IsNotNull(result.Date);
            Assert.IsNull(result.Sequence);
            Assert.IsNotNull(result.Email);
            Assert.IsNotNull(result.Logistics);
            Assert.IsNotNull(result.Ratings);
        }

        [TestMethod]
        public void ProductModel_AverageRating_Default_Should_Return_5()
        {
            // Arrange
            var model = new ProductModel();

            // Act
            var result = model.AverageRating();

            // Assert
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void ProductModel_AverageRating_Ratings_Null_Should_Return_0()
        {
            // Arrange
            var model = new ProductModel();
            model.Ratings = null;

            // Act
            var result = model.AverageRating();

            // Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void ProductModel_AverageRating_No_Items_Should_Return_0()
        {
            // Arrange
            var model = new ProductModel();
            model.Ratings = new int[0];

            // Act
            var result = model.AverageRating();

            // Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void ProductModel_AverageRating_Total_0_Should_Return_0()
        {
            // Arrange
            var model = new ProductModel();
            model.Ratings[0] = 0;

            // Act
            var result = model.AverageRating();

            // Assert
            Assert.AreEqual(0, result);
        }



    }
}
