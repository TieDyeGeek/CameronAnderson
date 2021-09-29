namespace Enigma.Machine
{
	public static class StandardRotor
	{
		public static Rotor I   => new Rotor("EKMFLGDQVZNTOWYHXUSPAIBRCJ", 16);
		public static Rotor II  => new Rotor("AJDKSIRUXBLHWTMCQGZNPYFVOE", 4);
		public static Rotor III => new Rotor("BDFHJLCPRTXVZNYEIWGAKMUSQO", 21);
		public static Rotor IV  => new Rotor("ESOVPZJAYQUIRHXLNFTGKDCMWB", 9);
		public static Rotor V   => new Rotor("VZBRGITYUPSDNHLXAWMJQOFECK", 25);
	}
}
