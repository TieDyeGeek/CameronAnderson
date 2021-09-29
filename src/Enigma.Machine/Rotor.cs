using System;

namespace Enigma.Machine
{
	public class Rotor
	{
		private readonly string _letters;
		private readonly int _notchPosition;

		public Rotor(string letters, int notchPosition)
		{
			_notchPosition = notchPosition;
			_letters = letters;
		}

		/// <summary>
		/// Zero-indexed position
		/// </summary>
		public int Position { get; set; }

		public char Decode(char letter)
		{
			var index = Constants.Alphabet.IndexOf(letter);
			return _letters[AdjustedForPosition(index)];
		} 
		
		public char Encode(char letter)
		{
			var index = _letters.IndexOf(letter);
			var afp = AdjustedForPosition(index);
			return Constants.Alphabet[AdjustedForPosition(index)];
			//var encodedLetter = Constants.Alphabet[AdjustedForPosition(index)];
			//return Constants.Alphabet[AdjustedForPosition(
				//Constants.Alphabet.IndexOf(encodedLetter))];
		}

		private int AdjustedForPosition(int index) => Math.Abs((index - Position) % _letters.Length);

		public void Turn()
		{
			Position++;
			Position %= _letters.Length;
		}

		public bool WillTurnNextRotor() => Position == _notchPosition;
	}
}
