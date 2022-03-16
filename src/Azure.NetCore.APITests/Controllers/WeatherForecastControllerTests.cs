using Microsoft.VisualStudio.TestTools.UnitTesting;
using Azure.NetCore.API.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Azure.NetCore.APITests.Controllers
{
    [TestClass()]
    public class WeatherForecastControllerTests
    {
        [TestMethod()]
        public void GetTest()
        {
            var controler = new WeatherForecastController(null);
            var result = controler.Get();
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Count() >0);
        }
    }
}