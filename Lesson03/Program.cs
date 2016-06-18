using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson03
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Tanya = new Person();
            Tanya.Name = "Tanya";
            Tanya.Age = 28;
            Tanya.SaysHello();
            Tanya.ShowAge();
            Console.WriteLine();

            Person tom = new Person("Tom");
            tom.Age = 47;
            tom.SaysHello();
            tom.ShowAge();
            Console.WriteLine();

            Person Mark = new Person(30);
            Mark.Name = "Mark";
            Mark.SaysHello();
            Mark.ShowAge();
            Console.WriteLine();

            Person Mary = new Person("Mary",23);
            Mary.SaysHello();
            Mary.ShowAge();

        }
    }
}
