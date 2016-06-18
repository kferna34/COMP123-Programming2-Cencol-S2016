using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lesson01_HelloWorldTest
{
    [TestClass]
    public class Lesson01_HelloWorldTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            //ARRANGE
            string expectedResult = "Hello,World!";
            //ACT
            string result = COMP123_Programming2_Cencol_S2016.Program.HelloWorldToConsole();
            //ASSERT
            Assert.AreEqual(expectedResult, result);
    }
}
}
