using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson03
{
    class Person
    {
        private string _name;
        private int _age;

        /// <summary>
        /// this is a public property for our private_name field
        /// </summary>
        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }

        }
        /// <summary>
        /// this is public property for out private_age field
        /// </summary>
        public int Age
        {
            get
            {
                return this._age;
            }
            set
            {
                this._age = value;
            }
        }
        /// <summary>
        /// this is the defailt empty constructor for the person class
        /// </summary>
        public Person()
        {
            this.Name = "Unknown name!";
            this.Age = 0;
        }

        /// <summary>
        /// this is a constructor that takes name as a param and passes to the name probate instance var
        /// </summary>
        /// <param name="name"></param>
        public Person(string name)
        {
            this.Name = name;
            this.Age = 0;
        }
        /// <summary>
        /// this is a constructor that takes age as a param and passes it to the age private instance var
        /// </summary>
        /// <param name="age"></param>
        public Person(int age)
        {
            this.Name = "Unknown name!";
            this.Age = age;
        }
        /// <summary>
        /// this is a constructor that takes both name and age property 
        /// also assigns the local age val to the age property
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;

        }
        /// <summary>
        /// this method outputs the name val with says hello to the console
        /// </summary>
        public void SaysHello()
        {
            Console.WriteLine(this.Name + "Says hello!");
        }
        public void ShowAge()
        {
            Console.WriteLine(this.Name + "is " + this.Age + "years old.");
        }
    }
}
