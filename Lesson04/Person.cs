using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson04
{
    class Person
    {
        // PRIVATE INSTANCE VAR
        private string _name;
        private int _age;

        //PUBLIC PROPERTIES

        ///<summary>
        ///this is  public property for out private _name field
        ///</summary>

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
        ///<summary>
        ///this is a property for out private _age field
        ///</summary>
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
        //CONSTRUCTORS

        ///<summary>
        ///this is the default empty constructor for the person class
        ///</summary>
        public Person(string name)
        {
            this._initialize();
            this.Name = name;
        }

        ///<summary>
        ///this is  constructor that takes age as a param and passes it to the _age private instance var
        ///</summary>

        public Person(int age)
        {
            this._initialize();
            this.Age = age;
        }
        ///<summary>
        ///this is  a constructor that takes both name and age as param.
        ///it assigns the local name value to the Name prop
        ///it assigns the local age value to the age prop
        ///</summary>
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        //PRIVATE METHOD
        ///<summary>
        ///this method initializes the public properties Name and Age
        ///</summary>
        private void _initialize()
        {
            this.Name = "unknown name!";
            this.Age = 0;
        }
        //Public method 

        ///<summary>
        ///this method outouts the _name value with "says hello!" to the console
        ///</summary>
        public void SaysHello()
        {
            Console.WriteLine(this.Name + "says hello!");
        }

        ///<summary>
        ///This method outputs the _name and _age values in the following
        ///format: _name + "is" +_age "years old"
        ///</summary>
        public void  ShowAge()
        {
            Console.WriteLine(this.Name + "is " + this.Age + "years old.");
        }

    }
}
