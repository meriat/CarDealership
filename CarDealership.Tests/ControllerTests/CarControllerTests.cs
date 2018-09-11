using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using CarDealership.Controllers;
using CarDealership.Models;

namespace CarDealership.Tests
{
    [TestClass]
    public class CarControllerTests
    {
      [TestMethod]
        public void Index_HasCorrectModelType_CarList()
        {
            //Arrange
            CarController controller = new CarController();
            ViewResult indexView = (ViewResult)controller.Index();

            //Act
            var result = indexView.ViewData.Model;

            //Assert
            Assert.IsInstanceOfType(result, typeof(List<Car>));
        }
    }
}
