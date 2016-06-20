using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson05
{


    /// <summary>
    /// this class extends the List<card> generic card
    /// </summary>
    public class Deck : List<Card>
    {
        ///<summary>
        ///this is default constructor for the deck class
        ///</summary>
        public Deck()
        {
            //create my deck of cards
            this._create();
        }
        //PRIVATE METHOD
        ///<summary>
        ///this method loads a lost of cards with card objects
        ///</summary>
        private void _create()
        {
            foreach (Suits suit in Enum.GetValues(typeof(Suits)))
            {
                foreach (Faces face in Enum.GetValues(typeof(Faces)))
                {
                    this.Add(new Card(face, suit));//anonymous Card obj to the list
                }
            }
        }

        public void Display()
        {
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("+ CURRENT DECK                               +");
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++");
            foreach (Card card in this)
            {
                Console.WriteLine("{0} of {1}", card.Face, card.Suit);
            }
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine();
        }
        public void Shuffle()
        {
            //create a pseudo- random number seq and stores it in random
            Random random = new Random();

            //records the number of cards in the deck list
            int cardCount = this.Count;

            //iterate through the list of cards
            for (int currentCard = 0; currentCard < cardCount; currentCard++)
            {
                Card tempCard = this[currentCard]; //copy current card to temp location
                int randomCard = random.Next(0, cardCount);//get a random card index
                this[currentCard] = this[randomCard];//copy val from randomCard to currentCard
                this[randomCard] = tempCard;//copy current to randm card
            }
        }
        ///<summary>
        ///this method will remove the 0th item from random Card from the deck and return it to random card
        ///</summary>
        public Card Deal()
        {
            Card topCard = this[0]; // copy the 0th card (top card) in the stack to the returnedCard
                                     //check to see if the deck is not empty
            if (this.Count > 0)
            {
                this.RemoveAt(0);//remove the 0th card == top card from deck
            }
            return topCard;
        }
    }
}

