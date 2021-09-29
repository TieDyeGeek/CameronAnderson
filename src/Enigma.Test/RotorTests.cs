using Enigma.Machine;
using Xunit;

namespace Enigma.Test
{
	public class RotorTests
	{
		private static Rotor Rotor = StandardRotor.I;

		[Fact]
		public void TurnTest()
		{
			Rotor.Position = 24;
			Rotor.Turn();
			Assert.Equal(25, Rotor.Position);
		}

		[Fact]
		public void TurnRolloverTest()
		{
			Rotor.Position = 25;
			Rotor.Turn();
			Assert.Equal(0, Rotor.Position);
		}

		[Fact]
		public void TranslatesBackToSameLetterTest()
		{
			var letter = Rotor.Encode('A');
			Assert.NotEqual('A', letter);

			var shouldBeA = Rotor.Decode(letter);
			Assert.Equal('A', shouldBeA);
		}

		[Fact]
		public void EncodeLetterTest()
		{
			var right = StandardRotor.III;
			var middle = StandardRotor.II;
			var left = StandardRotor.II;

			right.Position = 10;
			middle.Position = 25;
			left.Position = 1;

			var letter = right.Encode('H');
			Assert.Equal('J', letter);

			letter = middle.Encode(letter);
			Assert.Equal('P', letter);

			letter = left.Encode(letter);
			Assert.Equal('Z', letter);
		}

	}
}
