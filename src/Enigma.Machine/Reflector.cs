using System.Collections.Generic;

namespace Enigma.Machine
{
	public class Reflector
	{
		private readonly Dictionary<char, char> _letters;

		public Reflector(string letters)
		{
			_letters = new Dictionary<char, char>();
			for (int i = 0; i < Constants.Alphabet.Length; i++)
			{
				_letters.Add(Constants.Alphabet[i], letters[i]);
			}
		}

		public char Reflect(char letter)
		{
			return _letters[letter];
		}
	}
}
