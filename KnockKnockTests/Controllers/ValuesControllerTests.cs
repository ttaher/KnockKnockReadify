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

///api/values/ReverseWords sentence = trailing % 20space%20&X-ARR-LOG-ID=f873bfd9-45f3-45bf-aa0f-ef7314654795 443 - 65.52.168.84 - ARRAffinity=06fb770771bc781fdba780d4ae2dee40ec646d4fe38b09509f95b08402cf2fec - talattestknock.azurewebsites.net 200 0 0 461 1013 15
///api/values/ReverseWords sentence = Capital & X - ARR - LOG - ID = e0f2c58c - 57a3-4f88-a4e1-53506d2fdb68 443 - 65.52.168.84 - ARRAffinity=06fb770771bc781fdba780d4ae2dee40ec646d4fe38b09509f95b08402cf2fec - talattestknock.azurewebsites.net 200 0 0 452 977 15
///api/values/ReverseWords sentence = Bang % 21 & X - ARR - LOG - ID = 831a6909-6924-4b30-89ed-9b11b2de4339 443 - 65.52.168.84 - ARRAffinity=06fb770771bc781fdba780d4ae2dee40ec646d4fe38b09509f95b08402cf2fec - talattestknock.azurewebsites.net 200 0 0 450 977 15
///api/values/ReverseWords sentence =% C2 % BFQu % C3 % A9 % 3F & X - ARR - LOG - ID = b02cfc88 - ed08 - 4ff9-8323-77861dfd1174 443 - 65.52.168.84 - ARRAffinity=06fb770771bc781fdba780d4ae2dee40ec646d4fe38b09509f95b08402cf2fec - talattestknock.azurewebsites.net 200 0 0 452 1007 15
///api/values/ReverseWords sentence = detartrated % 20kayak%20detartrated&X-ARR-LOG-ID=aad58c83-6572-4878-9747-04217c6b2c3b 443 - 65.52.168.84 - ARRAffinity=06fb770771bc781fdba780d4ae2dee40ec646d4fe38b09509f95b08402cf2fec - talattestknock.azurewebsites.net 200 0 0 475 1055 15
///api/values/ReverseWords sentence = This % 20 is% 20a%20snark:%20%E2%B8%AE&X-ARR-LOG-ID=4a46a276-4e29-4df7-81b2-b244007ad3e0 443 - 65.52.168.84 - ARRAffinity=06fb770771bc781fdba780d4ae2dee40ec646d4fe38b09509f95b08402cf2fec - talattestknock.azurewebsites.net 200 0 0 466 1058 0
///api/values/ReverseWords sentence =% 20 % 20S%20%20P%20%20A%20%20C%20%20E%20%20Y%20%20&X-ARR-LOG-ID=6777e3bd-365c-4435-b1a6-074747f9bdef 443 - 65.52.168.84 - ARRAffinity=06fb770771bc781fdba780d4ae2dee40ec646d4fe38b09509f95b08402cf2fec - talattestknock.azurewebsites.net 200 0 0 466 1100 15
///api/values/ReverseWords sentence =% 21B%21A%21N%21G%21S%21&X-ARR-LOG-ID=b6c6a121-9468-44c7-a85c-61fb11cafec3 443 - 65.52.168.84 - ARRAffinity=06fb770771bc781fdba780d4ae2dee40ec646d4fe38b09509f95b08402cf2fec - talattestknock.azurewebsites.net 200 0 0 457 1025 31
///api/values/ReverseWords sentence = P % 21u % 40n%23c%24t%25u%5Ea%26t%2Ai%28o%29n&X-ARR-LOG-ID=aeeec8bf-4197-4d3d-b9c6-ca81cfc00e10 443 - 65.52.168.84 - ARRAffinity=06fb770771bc781fdba780d4ae2dee40ec646d4fe38b09509f95b08402cf2fec - talattestknock.azurewebsites.net 200 0 0 467 1079 15