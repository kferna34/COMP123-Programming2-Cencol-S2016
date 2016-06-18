using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lesson02_PartB;
namespace Lesson01_PartBUnitTest
{
    [TestClass]
    public class Lesson01_PartBUnitTest
    {
        [TestMethod]
            public void OutputStringToConsoleTestMethod()
        {
            //ARRANGE
            string outputString = "Enter UserName: ";
            bool hasNewLine = false;
            string actualResult;
            string expectedResult = "Enter UserName: ";

            //ACT
            actualResult = Lesson02_PartB.Program.OutputStringToConsole(outputString, hasNewLine);
            //ASSERT
        }
        }
    }
}
