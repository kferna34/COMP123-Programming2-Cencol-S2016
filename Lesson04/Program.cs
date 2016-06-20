using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson04
{
    class Program
    {
        static void Main(string[] args)
        {
            //create instance of the student class
            Student tommy = new Student("Tommy", 20, "S123456789");
            tommy.SaysHello();
            Console.WriteLine();
            tommy.Studies();
            tommy.Courses.Add(new Course("COMP123", "Programming2"));
            tommy.Courses.Add(new Course("COMP125", "Client-Sode Web Development"));
            tommy.Courses.Add(new Course("COMP397", "Web GameProgramming2"));
            tommy.ShowCourses();
            Console.WriteLine();

            //create instance of the teacher class
            Teacher tom = new Teacher("Tom", 47, "T123456789");
            tom.SaysHello();
            Console.WriteLine();
            tom.Teaches();

            List<string> names = new List<string>();
            names.Add("Tom");
            names.Add("Mary");
            names.Add("Rutvik");

            int count = 0;
            Console.WriteLine();
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++");
            foreach (string name in names)
            {
                Console.WriteLine("Name #" + count + " is " + name);
                count++;
            }
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++");
            List<Card> Deck = new List<Card>();
            CreateDeck(Deck);
        }
        public static void CreateDeck(List<Card>deck)
        {
            string suit = "";
            for (int i = 0; i < 4; i++)
            {
                switch (i)
                {
                   case 0:
                        suit = "hearts";
                        break;
                    case 1:
                        suit = "clubs";
                        break;
                    case 2:
                        suit = "diamonds";
                        break;
                    case 3:
                        suit = "spades";
                        break;
                }
                for (int face = 1; face < 14; face++)
                {
                    deck.Add(new Card(face, suit));
                }
            }
        }
        }
    }
}
