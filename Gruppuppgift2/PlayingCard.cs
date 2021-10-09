using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupAssignment2
{
	public enum PlayingCardColor
	{
		Clubs = 0, Diamonds, Hearts, Spades         // Poker suit order, Spades highest
	}
	public enum PlayingCardValue
	{
		Two = 2, Three, Four, Five, Six, Seven, Eight, Nine, Ten,
		Knight, Queen, King, Ace                // Poker Value order
	}
	public class PlayingCard
	{
		public PlayingCardColor Color { get; init; }
		public PlayingCardValue Value { get; init; }

		public string BlackOrRed
		{
			get
			{
				if (Color == PlayingCardColor.Clubs || Color == PlayingCardColor.Spades)
					return "Black";

				return "Red";
			}
		}

		/// <summary>
		/// Returns "Face" for Ace,Knight, Queen, King. Otherwise it returns "Value".
		/// 
		/// </summary>
		string FaceOrValue
		{
			get
			{
				if (Value >= PlayingCardValue.Knight)
				{
					return "Face";
				}
				return "Value";


			}
		}
		public override string ToString() => $"{Value} of {Color}, a {BlackOrRed} {FaceOrValue} card";

		/// <summary>
		/// Constructor that generates a random card
		/// </summary>
		public PlayingCard()
		{
			Random rnd = new Random();
			int randomColor = rnd.Next(0, 3);
			Color = (PlayingCardColor)randomColor;


			int randomValue = rnd.Next(2, 14);
			Value = (PlayingCardValue)randomValue;




		}
	}
}