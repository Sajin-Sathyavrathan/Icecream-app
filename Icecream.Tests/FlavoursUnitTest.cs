using System;
using System.Text;
using System.Collections.Generic;
using System.Web.Http.Results;
using IcecreamParlour.Service.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Icecream.Tests
{
    /// <summary>
    /// Summary description for FlavoursUnitTest
    /// </summary>
    [TestClass]
    public class FlavoursUnitTest
    {
        public FlavoursUnitTest()
        {
            //
            // TODO: Add constructor logic here
            //
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
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void FlavoursGetByIdSuccess()
        {
            // Set up Prerequisites 
            var controller = new FlavoursController();

            // Act on Test
            var response = controller.GetFlavour(1);
            //var contentResult = response as OkNegotiatedContentResult<Flavours>;

            //// Assert the result
            //Assert.IsNotNull(contentResult);
            //Assert.IsNotNull(contentResult.Content);
            //Assert.AreEqual(1, contentResult.Content.);

        }

    }
}
