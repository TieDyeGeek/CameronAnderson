using System;
using System.Collections.Generic;
using System.Linq;
using CameronAnderson.Wordle;

namespace CameronAnderson.Pages.Wordle;

public class Letter
{
	public Letter(char letter)
	{
		Value = letter;
		Positions = new List<int>();
	}

	public char Value { get; set; }
	public List<int> Positions { get; set; }
	public Correctness Correctness { get; set; }

	public IEnumerable<WordleLetter> ToWordleLetters()
	{
		if (Correctness == Correctness.Unknown) return new List<WordleLetter>();

		if (Correctness == Correctness.Incorrect)
			return new List<WordleLetter>
			{
				new WordleLetter(Value, Correctness)
			};

		return Positions.Select(x => new WordleLetter(Value, Correctness, x));
	}
}
