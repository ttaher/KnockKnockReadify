using Microsoft.VisualStudio.TestTools.UnitTesting;
using KnockKnock.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Web.Http;

namespace KnockKnock.Controllers.Tests
{
    [TestClass()]
    public class ValuesControllerTests
    {
        [TestMethod()]
        public void FibonacciCalcTest()
        {
            var controller = new ValuesController();
            Assert.AreEqual(139583862445, controller.Get(-55));
            Assert.AreEqual(-86267571272, controller.Get(-54));
            Assert.AreEqual(-12586269025, controller.Get(-50));
            Assert.AreEqual(-55, controller.Get(-10));
            Assert.AreEqual(5, controller.Get(-5));
            Assert.AreEqual(-1, controller.Get(-2));
            Assert.AreEqual(0, controller.Get(0));
            Assert.AreEqual(1, controller.Get(1));
            Assert.AreEqual(5, controller.Get(5));
            Assert.AreEqual(55, controller.Get(10));
            Assert.AreEqual(12586269025, controller.Get(50));
            Assert.AreEqual(86267571272, controller.Get(54));
            Assert.AreEqual(139583862445, controller.Get(55));

        }
        [TestMethod()]
        public void TokenTest()
        {
            var controller = new ValuesController();

            Assert.AreEqual("26d91d08-63b7-4171-a74c-90d9f9b648d5", controller.Get());
        }
        [TestMethod()]
        public void ReverseWordsTest()
        {
            var controller = new ValuesController();
            Assert.AreEqual("", controller.Get(""));
            Assert.AreEqual("", controller.Get("  "));
            Assert.AreEqual("", controller.Get("\n"));
            Assert.AreEqual("rima rehat ahsab", controller.Get("amir taher basha"));
            Assert.AreEqual(" tI t'nseod deen ot noitnem edocinu", controller.Get(" It doesn't need to mention unicode"));
        }
        [TestMethod()]
        public void TriangleTypeCalcTest()
        {
            var controller = new ValuesController();
            Assert.AreEqual("Equilateral", controller.Get(4, 4, 4));
            Assert.AreEqual("Scalene", controller.Get(5, 3, 6));
        }
    }
}