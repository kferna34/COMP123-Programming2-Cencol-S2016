using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_Programming2_Cencol_S2016
{
    class Program
    {
        static void Main(string[] args)
        {
            //call the hello world to console method
            HelloWorldToConsole();
        }
        /*
         * @description this is my Hello World method
         * @method HelloWorldToConsole
         * @return {string} HelloWorld
         */
         
        public static string HelloWorldToConsole()
        {
            string HelloWorldString = "Hello,World!";
            Console.WriteLine(HelloWorldString);
            return HelloWorldString;
        }
    }
}
