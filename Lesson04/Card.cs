using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson04
{

    /// <summary>
    /// this class creates an object that represents a playing card
    /// </summary>
    public class Card
    {
        //PUBLIC PROP
        public int Face { get; set; }
        public string Suit { get; set; }

        /// <summary>
        /// this constructor takes two parameters : face and suit to instantiate a Card object
        /// </summary>

        public Card(int face, string suit)
        {
            this.Face = face;
            this.Suit = suit;
        }

    }
}

