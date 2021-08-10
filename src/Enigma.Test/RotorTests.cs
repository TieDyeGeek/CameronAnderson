using Enigma.Machine;
using System;
using Xunit;

namespace Enigma.Test
{
	public class RotorTests
	{
		[Fact]
		public void SetPositionTest()
		{
			var rotor = GetRotor();
			rotor.SetPosition(23);
			Assert.Equal(23, rotor.GetPosition());
		}

		[Fact]
		public void SetPositionTooHighTest()
		{
			var rotor = GetRotor();
			Assert.Throws<ArgumentException>(() => rotor.SetPosition(26));
		}

		[Fact]
		public void SetPositionTooLowTest()
		{
			var rotor = GetRotor();
			Assert.Throws<ArgumentException>(() => rotor.SetPosition(-1));
		}

		[Fact]
		public void TurnTest()
		{
			var rotor = GetRotor();
			rotor.SetPosition(24);
			rotor.Turn();
			Assert.Equal(25, rotor.GetPosition());
		}

		[Fact]
		public void TurnRolloverTest()
		{
			var rotor = GetRotor();
			rotor.SetPosition(25);
			rotor.Turn();
			Assert.Equal(0, rotor.GetPosition());
		}

		private Rotor GetRotor() => StandardRotor.I;
	}
}
