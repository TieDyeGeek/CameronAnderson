using System;
using System.Collections.Generic;

namespace Enigma.Machine
{
	public class Rotor
	{
		private readonly Dictionary<char, char> _letters;
		private int _position;
		private readonly int _notchPosition;

		public Rotor(string letters, int notchPosition)
		{
			_notchPosition = notchPosition;
			_letters = new Dictionary<char, char>();
			for (int i = 0; i < Constants.Alphabet.Length; i++)
			{
				_letters.Add(Constants.Alphabet[i], letters[i]);
			}
		}

		/// <summary>
		/// Zero-indexed position
		/// </summary>
		public int GetPosition() => _position;

		/// <summary>
		/// Zero-indexed position
		/// </summary>
		public void SetPosition(int position)
		{
			if (position >= _letters.Count || position < 0) throw new ArgumentException();

			_position = position;
		}

		public char Translate(char letter)
		{
			return _letters[letter];
		}

		public void Turn()
		{
			_position++;
			_position %= _letters.Count;
		}

		public bool WillTurnNextRotor() => _position == _notchPosition;
	}
}
