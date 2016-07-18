using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson06__PlayerProject
{
    public abstract class Enemy : GameObject
    {
        
        private int _morale;

        public int Morale
        {
            get
            {
                return this._morale;
            }

            set
            {
                this._morale = value;
            }
        }
        public Enemy(string name) : base (name)

        public void Flee()
        {
            throw new System.NotImplementedException();
        }

        public void Seek()
        {
            throw new System.NotImplementedException();
        }
    }
}
