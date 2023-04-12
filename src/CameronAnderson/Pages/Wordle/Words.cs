using System.Collections.Generic;
using System.Linq;
using CameronAnderson.Wordle;

namespace CameronAnderson.Pages.Wordle;

public class Words
{
	public Words()
	{
		Letters = new List<WordleLetter>();
	}

	public List<WordleLetter> Letters { get; private set; }

	public void AddLetter(char letter)
	{
		var position = Letters.Count % 5;
		Letters.Add(new WordleLetter(letter, Correctness.Incorrect, position));
	}

	public void RemoveLetter()
	{
		if (Letters.Any())
			Letters.Remove(Letters.Last());
	}
}
