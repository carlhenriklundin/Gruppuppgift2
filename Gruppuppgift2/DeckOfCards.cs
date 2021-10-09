using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupAssignment2
{
    class DeckOfCards
    {
        const int MaxNrOfCards = 52;

        PlayingCard[] cards = new PlayingCard[MaxNrOfCards];

        public PlayingCard this[int idx]
        {
            get
            {
                return cards[idx];
            }
        }

        int nrOfCards => cards.Length;
        /// <summary>
        /// Number of Cards in the deck
        /// </summary>
        ///
        public int Count;

        /// <summary>
        /// Overriden and used by for example Console.WriteLine()
        /// </summary>
        /// <returns>string that represents the complete deck of cards</returns>
        public override string ToString()
        {
            string sRet = "";
            for (int i = 0; i < nrOfCards; i++)
            {
                if (cards[i] != null)
                    sRet += cards[i].ToString() + "\n";
            }
            return sRet;
        }

        /// <summary>
        /// Shuffles the deck of cards
        /// </summary>
        public void Shuffle()
        {
            var rnd = new Random(); //rnd is now a random generator - see .NET documentation


            for (int i = 0; i < 1000; i++)
            {
                int randomCard1 = rnd.Next(0, 51);
                int randomCard2 = rnd.Next(0, 51);
                PlayingCard tmp = cards[randomCard1];
                cards[randomCard1] = cards[randomCard2];
                cards[randomCard2] = tmp;

            }

        }

        /// <summary>
        /// Initialize a fresh deck consisting of 52 cards
        /// </summary>
        public void FreshDeck()
        {
            int cardNr = 0;


            for (int arrayColor = 0; arrayColor < 4; arrayColor++)
            {

                for (int arrayValue = 2; arrayValue < 15; arrayValue++)
                {
                    cards[cardNr] = new PlayingCard() { Value = (PlayingCardValue)arrayValue, Color = (PlayingCardColor)arrayColor };
                    cardNr++;
                }

            }
            Count = cards.Length;
        }

        /// <summary>
        /// Removes the top card in the deck and 
        /// </summary>
        /// <returns>The card removed from the deck</returns>
        public PlayingCard GetTopCard()
        {
            for (int i = 0; i < cards.Length; i++)
            {
                if (cards[i] != null)
                {
                    PlayingCard tmp = cards[i];
                    cards[i] = null;
                    Count -= 1;

                    return tmp;
                }
            }

            //YOUR CODE
            //to return the Top card of the deck and reduce the nr of cards in the deck
            return null;
        }

        public DeckOfCards()
        {
            FreshDeck();
        }
    }
}
