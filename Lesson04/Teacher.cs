using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson04
{
    /// <summary>
    /// the teacher is derived from the person class
    /// </summary>
    class Teacher : Person
    {
        //PRIVATE VAR
        private string _employeeID; 

        //PUBLIC PROP
        public string EmployeeID
        {
            get
            {
                return this._employeeID;
            }
            set
            {
                this._employeeID = value;
            }
        }
        //CONSTRUCTORS
        ///<summary>
        ///this constructor method takes three param: name, age, employeeID
        ///</summary>
        public Teacher (string name , int age,string employeeID) : base(name,age)
        {
            this.EmployeeID = employeeID;
        }
        //PUBLIC METHOD
        ///<summary>
        ///this method enables the teaches behaviour for the Teacher class
        ///</summary>
        public void Teaches()
        {
            Console.WriteLine( this.Name + "teaches, ");
        }
    }
}
