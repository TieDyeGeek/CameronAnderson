namespace CameronAnderson.Wordle;

public static class Solver
{
	public static List<string> Solve(List<WordleLetter> letters)
	{
		if (!letters.IsValid()) throw new Exception("Bad Input");

		letters = letters.Where(x => x.Correctness != Correctness.Unknown).ToList();

		return Words.All()
			.RemoveWordsWithIncorrectLetters(letters)
			.RemoveWordsWithWrongLetterPosition(letters)
			.RemoveWordsWithoutYellowLetters(letters);
	}

	private static bool IsValid(this List<WordleLetter> letters)
	{
		//positions greater than 5
		if (letters.Any(x => x.Position > 4)) return false;

		if (letters.Any(x => x.Position < 0)) return false;

		//duplicate positions
		for (uint i = 0; i < 5; i++)
		{
			if (letters.Where(x =>
					x.Correctness == Correctness.Correct
					&& x.Position == i)
				.Count() > 1) return false;
		}

		return true;
	}

	private static List<string> RemoveWordsWithIncorrectLetters(this List<string> words, List<WordleLetter> letters)
	{
		IEnumerable<string> filteredWords = words;

		var incorrectLetters = letters
			.Where(x => x.Correctness == Correctness.Incorrect)
			.Select(x => x.Letter);

		foreach (var letter in incorrectLetters)
		{
			filteredWords = filteredWords.Where(x => !x.Contains(letter));
		}

		return filteredWords.ToList();
	}

	private static List<string> RemoveWordsWithWrongLetterPosition(this List<string> words, List<WordleLetter> letters)
	{
		IEnumerable<string> filteredWords = words;

		var correctLetters = letters.Where(x => x.Correctness == Correctness.Correct);

		foreach (var letter in correctLetters)
		{
			filteredWords = filteredWords.Where(x => x[letter.Position ?? 0].Equals(letter.Letter));
		}

		return filteredWords.ToList();
	}

	private static List<string> RemoveWordsWithoutYellowLetters(this List<string> words, List<WordleLetter> letters)
	{
		IEnumerable<string> filteredWords = words;

		var yellowLetters = letters
			.Where(x => x.Correctness == Correctness.WrongSpot);

		foreach (var letter in yellowLetters)
		{
			filteredWords = filteredWords.Where(x => x.Contains(letter.Letter));

			if (letter.Position == null) continue;

			filteredWords = filteredWords.Where(x => !x[(int)letter.Position].Equals(letter.Letter));
		}

		return filteredWords.ToList();
	}
}
