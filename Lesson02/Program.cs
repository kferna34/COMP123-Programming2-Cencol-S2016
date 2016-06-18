using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson02
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 50;
            int y = 40;
            int result = 0;
            int numberOfEntries;

            result = addXandY(x, y);
            Console.WriteLine(result);
            Console.WriteLine();

            addYtoX(ref x, ref y);

            Console.WriteLine(x);
            Console.WriteLine();

            Console.WriteLine("How many entries do you want to make? ");
            int.TryParse(Console.ReadLine(), out numberOfEntries);
            if(numberOfEntries > 0)
            {
                readUntilEnd(numberOfEntries);
            }
        }
        /*
         * simple method to add two val
         */
        public static int addXandY(int firstNumber,int secondNumber)
        {
            int result = 0;
            result = firstNumber + secondNumber;
            return result;
        }
        /*
         * simple method to demonstrate pass by reference with ref keyword
         */
         public static int addYtoX(ref int X, ref int Y)
        {
            X += Y;
            return X;
        }

        public static int readUntilEnd(int numberOfEntries)
        {
            //VAR DECLARATION
            string[] inputs = new string[numberOfEntries];
            int inputCounter = 0;

            //EXECUTE THE CODE

            do
            {
                Console.WriteLine("Enter a value - ('end' to stop): ");
                inputs[inputCounter] = "";
                inputs[inputCounter] = Console.ReadLine();
                inputCounter++;
            }
            while ((inputs[inputCounter - 1] != "end") && (inputCounter < numberOfEntries));
            return inputCounter;
        }

    }
}
