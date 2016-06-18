using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Author : Krytia Fernandez
 * Date Created: 05-13
 * Date Modified: 05-13
 * 
 */
namespace Lesson01_PartB
{
    /*
     *this is the driver class for our program 
     * 
     * @class program 
     */
   public class Program
    {
        static void Main(string[] args)
        {
            GetUserName();
        }
        /*
         * THis method reads the UserName from the console
         * 
         * @method GetUserName
         * @return {string} UserName
         */
        public static string GetUserName()
        {
            //initialize var
            string UserName = "";

            OutputStringToConsole("Enter UserName:", false);
            UserName = Console.ReadLine();

            Console.WriteLine("\n======================================\n");
            Console.WriteLine("You Entered : " + UserName + "\n");

            return UserName;
        }
        /*
         * This method writes a string to the console. param allows the user to choose to ass a newLine character
         * 
         */
        public static string OutputStringToConsole(string outputString, bool hasNewLine)
        {
            //refractored using the ternary operator
            string suffixString = hasNewLine ? "\n" : "";
            Console.WriteLine(outputString + suffixString);
            return outputString;
        }
    }
}

