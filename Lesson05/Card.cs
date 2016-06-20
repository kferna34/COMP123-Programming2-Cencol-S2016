using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson05
{
   public class Card
    {
        //PUBLIC PROP
        public Faces Face { get; set; }
        public Suits  Suit { get; set; }

        /// <summary>
        /// this constructor takes two parameters : face and suit to instantiate a Card object
        /// </summary>

        public Card(Faces face, Suits suit)
        {
            this.Face = face;
            this.Suit = suit;
        }
    }
}
