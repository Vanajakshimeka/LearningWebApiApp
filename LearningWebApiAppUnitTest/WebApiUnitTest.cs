using LearningWebApiApp.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LearningWebApiAppUnitTest
{
    [TestClass]
    public class WebApiUnitTest
    {
        string response;

        /// <summary>
        /// Method for common variable initialization
        /// </summary>
        [TestInitialize]
        public void TestInitialize()
        {
            var controller = new ValuesController();
             response = controller.Get();  // Installed Microsoft.AspNet.WebApi.Core 5.2.7
        }

        /// <summary>
        /// Test case for data is not null
        /// </summary>
        [TestMethod]
        public void TestStringNotEmpty()
        {
            Assert.IsNotNull(response);
        }

        /// <summary>
        /// Test case for string are equal
        /// </summary>
        [TestMethod]
        public void TestMatchingString()
        {
            Assert.AreEqual("Sample local API string Data to display in the UI", response);
        }

        /// <summary>
        /// Test case for string are not equal
        /// </summary>
        [TestMethod]
        public void TestNonMatchingString()
        {
            Assert.AreNotEqual("Test", response);
        }
    }
}
