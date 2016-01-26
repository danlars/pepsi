using System;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using webplatform.Controllers;

namespace webplatform.Tests.Controllers
{
    [TestClass]
    public class LoginControllerTest
    {
        //LoginController
        LoginController controller = new LoginController();

        [TestMethod]
        public void Index()
        {
            ViewResult result = controller.Index() as ViewResult;



            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void NewUser()
        {
            ViewResult result = controller.NewUser() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
