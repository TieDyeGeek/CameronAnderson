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
 
		public void SetPositions(int left, int middle, int right)
		{
			_left.Position = left;
			_middle.Position = middle;
			_right.Position = right;
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
			IncrementRotors();

			var e = _right.Encode(letter);
			e = _middle.Encode(e);
			e = _left.Encode(e);
			e = _reflector.Reflect(e);
			e = _left.Decode(e);
			e = _middle.Decode(e);
			e = _right.Decode(e);
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
