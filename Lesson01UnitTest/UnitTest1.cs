using System;
using Lesson02;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lesson02UnitTest
{
    [TestClass]
    public class Lesson02UnitTest
    {
        [TestMethod]
        public void addXandYTestMethod()
        {
            //ARRANGE
            int x = 40;
            int y = 50;
            int expectedResult = 90;

            //ACT
            int result = Lesson02.Program.addXandY(x, y);

            //ASSERT
            Assert.AreEqual(expectedResult, result);
    }
        [TestMethod]
        public void addYtoXTestMethod()
        {
            //ARRANGE
            int x = 40;
            int y = 50;
            int expectedResult = 90;

            //ACT
            int result = Program.addYtoX(ref x, ref y);

            //ASSERT
            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        public void readUntilEndTestMethod()
        {
            //ARRANGE
            int numberOfEntries = 5;
            int expectedCount = 5;
            int actualCount = 0;

            //ACT
            actualCount = Program.readUntilEnd(numberOfEntries);

            //ASSERT
            Assert.AreEqual(expectedCount, actualCount);
        }



    }
}
