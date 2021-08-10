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
