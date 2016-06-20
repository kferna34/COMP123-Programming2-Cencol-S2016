using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson04
{
    /// <summary>
    /// this is the course class -- we are using this as a custom data class type for out teacher and student
    /// </summary>
    class Course
    {
        //PRIVATE INSTANCE VAR
        private string _code;
        private string _description;
        
        //PUBLIC PROPERTIES
        public string Code
        {
            get
            {
                return this._code;
            }
            set
            {
                this._code = value;
            }
        }
        public string Description
        {
            get
            {
                return this._description;
            }
            set
            {
                this._description = value;
            }
        }
        //CONSTRUCTORS

        ///<summary>
        ///this constructor takes two param : Code and description
        ///</summary>
        
        public Course (string code, string description)
        {
            this.Code = code;
            this.Description = description;
        }
    }
}
