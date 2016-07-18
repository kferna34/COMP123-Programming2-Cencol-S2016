using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson07
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random(); // pseudo number object
            List<int> diceRolls = new List<int>();
            int[] tally = new int[13];
            int maxRolls = 5000000;

            // builds the list
            for (int index = 0; index < maxRolls; index++)
            {
                int firstDie = random.Next(1, 7);
                int secondDie = random.Next(1, 7);
                int dice = firstDie + secondDie;
                tally[dice]++; 
                diceRolls.Add(dice);
            }

            diceRolls.Sort();

            // display list
            /*
            foreach (int result in diceRolls)
            {
                Console.Write(result + " ");
            }
            Console.WriteLine();
            */

            for (int index = 2; index < 13; index++)
            {
                Console.WriteLine("{0}: {1} ", index, tally[index]);
            }
        }
    }
}
