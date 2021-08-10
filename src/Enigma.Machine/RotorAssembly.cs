namespace Enigma.Machine
{
	public class RotorAssembly
	{
		private readonly Rotor _left;
		private readonly Rotor _middle;
		private readonly Rotor _right;
		private readonly Reflector _reflector;

		public RotorAssembly(Rotor left, Rotor middle, Rotor right, Reflector reflector)
		{
			_left = left;
			_middle = middle;
			_right = right;
			_reflector = reflector;
		}
 
		public string EncodeText(string text)
		{
			string encodedText = "";

			foreach(var letter in text)
			{
				encodedText += EncodeLetter(letter);
			}

			return encodedText;
		}

		public char EncodeLetter(char letter)
		{
			var e = _right.Translate(letter);
			e = _middle.Translate(e);
			e = _left.Translate(e);
			e = _reflector.Reflect(e);
			e = _left.Translate(e);
			e = _middle.Translate(e);
			e = _right.Translate(e);

			IncrementRotors();

			return e;
		}

		private void IncrementRotors()
		{
			var turnMiddle = _right.WillTurnNextRotor();
			var turnLeft = _middle.WillTurnNextRotor();

			_right.Turn();
			if (turnMiddle) _middle.Turn();
			if (turnMiddle && turnLeft) _left.Turn();
		}
	}
}
