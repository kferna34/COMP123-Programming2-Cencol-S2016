using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson04
{
    /// <summary>
    /// this is the student class. it is derived from the person class
    /// </summary>
    class Student : Person
    {
        //private var
        public string _studentID;
        public List<Course> _courses = new List<Course>();

        //Public var
        ///<summary>
        ///this property, StudentId, includes a getter and setter for the private instance var _studentID
        ///</summary>
        public string StudentID
        {
            get
            {
                return this._studentID;
            }
            set
            {
                this._studentID = value;
            }
        }
        ///<summary>
        ///this read-only prop gets a ref to the _courses -- a list obj of Course type
        ///</summary>
        public List<Course> Courses
        {
            get
            {
                return this._courses;
            }
        }
        //CONSTRUCTORS

        ///<summary>
        ///this constructor takes three param: name, age,studentID
        ///</summary>
        public Student(string name, int age, string studentID) : base(name, age)
        {
            this.StudentID = studentID;
        }

        //PUBLIC METHOD
        ///<summary>
        ///this method enables the studies behaviour for the student
        ///</summary>
        public void Studies()
        {
            Console.WriteLine(this.Name + "studies");
        }

        ///<summary>
        ///this method lists all the courses the student is currently enrolled in
        ///</summary>
        public void ShowCourses()
        {
            Console.WriteLine();
            Console.WriteLine("Couorse List");
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++");
            foreach (Course course in this._courses)
            {
                Console.WriteLine("+" + course.Code + "" + course.Description);
            }
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine();
        }
    }
}
