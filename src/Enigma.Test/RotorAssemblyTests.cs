using Enigma.Machine;
using System;
using Xunit;

namespace Enigma.Test
{
	public class RotorAssemblyTests
	{
		[Fact]
		public void Encode()
		{
			var assembly = GetRotorAssembly();
			var encodedLetter = assembly.EncodeLetter('A');
			Assert.NotEqual('A', encodedLetter);

			assembly = GetRotorAssembly();
			var decodedLetter = assembly.EncodeLetter(encodedLetter);
			Assert.Equal('A', decodedLetter);
		}

		[Fact]
		public void EnigmaTest()
		{
			//for (int i = 0; i < 26; i++)
			//{
			//	for(int j = 0; j < 26; j++)
			//	{
			//		for(int k = 0; k < 26; k++)
			//		{
			//			var assembly = new RotorAssembly(StandardRotor.I, StandardRotor.II,
			//				StandardRotor.III, StandardReflector.B);
			//			assembly.SetPositions(i, j, k);
			//			var decodedText = assembly.EncodeText("BIWUTC");

			//			if (decodedText.Equals("ENIGMA"))
			//			{
			//				var q = 7;
			//			}
			//		}
			//	}
			//}

			var assembly = new RotorAssembly(StandardRotor.I, StandardRotor.II,
				StandardRotor.III, StandardReflector.B);
			assembly.SetPositions(10, 4, 19);
			var decodedText = assembly.EncodeText("QMJIDO");
			Assert.Equal("ENIGMA", decodedText);
		}

		[Fact]
		public void EncodeText()
		{
			var assembly = GetRotorAssembly();
			var encodedText = assembly.EncodeText("HELLOWORLD");
			Assert.Equal("YAKZCOMLTK", encodedText);
		}

		private RotorAssembly GetRotorAssembly() => 
			new RotorAssembly(StandardRotor.I, StandardRotor.II, StandardRotor.III, 
				StandardReflector.B);
	}
}
