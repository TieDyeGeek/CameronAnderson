using System;
namespace CameronAnderson.Wordle;

public record WordleLetter(char Letter, Correctness Correctness, int? Position = null);

public enum Correctness
{
	Unknown,
	Correct,
	WrongSpot,
	Incorrect
}
