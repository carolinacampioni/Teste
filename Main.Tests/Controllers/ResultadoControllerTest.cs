using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebSite;
using WebSite.Controllers;

namespace WebSite.Tests.Controllers
{
    [TestClass]
    public class ResultadoControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            ResultadoController controller = new ResultadoController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }


       
    }
}
