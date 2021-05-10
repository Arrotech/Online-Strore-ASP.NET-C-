using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OnlineStore.Controllers;
using OnlineStore.Models;

namespace OnlineStoreTest
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void HomePageTest()
        {
            var controller = new HomeController();
            var result = controller.Index() as ViewResult;
            Assert.AreEqual("Index", result.ViewName);
        }
    }
}
