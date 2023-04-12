namespace CameronAnderson.Wordle;

public class WordleLetter
{
	public WordleLetter(char letter, Correctness correctness, int? position = null)
	{
		Letter = letter;
		Correctness = correctness;
		Position = position;
	}

	public char Letter { get; }
	public Correctness Correctness { get; set; }
	public int? Position { get; }
}

public enum Correctness
{
	Unknown,
	Correct,
	WrongSpot,
	Incorrect
}
