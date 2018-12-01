using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KnockKnock.Controllers.Tests
{
    [TestClass()]
    public class ValuesControllerTests
    {
        [TestMethod()]
        public void FibonacciCalcTest()
        {
            ValuesController controller = new ValuesController();
            Assert.AreEqual(139583862445, controller.Get(-55).Result);
            Assert.AreEqual(-86267571272, controller.Get(-54).Result);
            Assert.AreEqual(-12586269025, controller.Get(-50).Result);
            Assert.AreEqual(-55, controller.Get(-10).Result);
            Assert.AreEqual(5, controller.Get(-5).Result);
            Assert.AreEqual(55, controller.Get(10).Result);
            Assert.AreEqual(12586269025, controller.Get(50).Result);
            Assert.AreEqual(86267571272, controller.Get(54).Result);
            Assert.AreEqual(139583862445, controller.Get(55).Result);

            Assert.AreEqual(-3, controller.Get(-4).Result);
            Assert.AreEqual(2, controller.Get(-3).Result);
            Assert.AreEqual(-1, controller.Get(-2).Result);
            Assert.AreEqual(1, controller.Get(-1).Result);
            Assert.AreEqual(0, controller.Get(0).Result);
            Assert.AreEqual(1, controller.Get(1).Result);
            Assert.AreEqual(1, controller.Get(2).Result);
            Assert.AreEqual(2, controller.Get(3).Result);
            Assert.AreEqual(3, controller.Get(4).Result);
            Assert.AreEqual(5, controller.Get(5).Result);
            Assert.AreEqual(8, controller.Get(6).Result);
            Assert.AreEqual(13, controller.Get(7).Result);
            Assert.AreEqual(1836311903, controller.Get(46).Result);
            Assert.AreEqual(2971215073, controller.Get(47).Result);
            Assert.AreEqual(2971215073, controller.Get(-47).Result);
            Assert.AreEqual(13, controller.Get(-7).Result);
            Assert.AreEqual(-8, controller.Get(-6).Result);
            Assert.AreEqual(-1836311903, controller.Get(-46).Result);
            //Assert.AreEqual(-7540113804746346000, controller.Get(-92).Result);
            //Assert.AreEqual(7540113804746346000, controller.Get(92).Result);
            //Assert.AreEqual("no content", controller.Get(-93).Result);
            //Assert.AreEqual("no content", controller.Get(93).Result);
            //Assert.AreEqual("no content", controller.Get(-9223372036854775808).Result);
        }
        [TestMethod()]
        public void TokenTest()
        {
            ValuesController controller = new ValuesController();

            Assert.AreEqual("26d91d08-63b7-4171-a74c-90d9f9b648d5", controller.Get());
        }
        [TestMethod()]
        public void ReverseWordsTest()
        {
            ValuesController controller = new ValuesController();
            Assert.AreEqual("", controller.Get(""));
            Assert.AreEqual("", controller.Get("  "));
            Assert.AreEqual("", controller.Get("\n"));
            Assert.AreEqual("ALO", controller.Get("OLA"));
            Assert.AreEqual("rima rehat ahsab", controller.Get("amir taher basha"));
            Assert.AreEqual("321 654 987", controller.Get("123 456 789"));
            Assert.AreEqual(" tI t'nseod deen ot noitnem edocinu", controller.Get(" It doesn't need to mention unicode"));
            Assert.AreEqual(" tac ", controller.Get(" cat "));
            Assert.AreEqual("tac dna god", controller.Get("cat and dog"));
            Assert.AreEqual("owt  secaps", controller.Get("two  spaces"));
        }
        [TestMethod()]
        public void TriangleTypeCalcTest()
        {
            ValuesController controller = new ValuesController();
            Assert.AreEqual("Error", controller.Get(1000, 100, 1));
            Assert.AreEqual("Equilateral", controller.Get(4, 4, 4));
            Assert.AreEqual("Equilateral", controller.Get(2147483647, 2147483647, 2147483647));
            Assert.AreEqual("Scalene", controller.Get(5, 3, 6));
            Assert.AreEqual("Error", controller.Get(0, 0, 0));
            Assert.AreEqual("Error", controller.Get(-1, -1, -1));
            Assert.AreEqual("Error", controller.Get(-1, 1, 1));
            Assert.AreEqual("Error", controller.Get(1, 1, 2));
        }
    }
}
