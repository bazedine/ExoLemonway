using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using webservice.test.ServiceWebFX;


namespace webservice.test
{
    [TestClass]
    public class ServiceWebTest
    {
        [TestMethod]
        public void FibonacciTest()
        {
            //////////////////////////////////////
            /// test for the fibonac method 
            /// with the number 10 for result 55
            /////////////////////////////////////

            WebServiceFXSoapClient client = new WebServiceFXSoapClient();
            var reponse = client.Fibonacci(10);
            Assert.AreEqual(55, reponse, "result incorrect");
        }

       
    }
}
