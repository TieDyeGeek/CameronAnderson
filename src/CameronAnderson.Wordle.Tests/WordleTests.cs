namespace CameronAnderson.Wordle.Tests;

public class WordleTests
{
    [Fact]
    public void EveryTest()
    {
        var inputs = new List<WordleLetter>()
        {
            new WordleLetter('e', Correctness.Correct, 2),
            new WordleLetter('e', Correctness.WrongSpot, 3),
            new WordleLetter('e', Correctness.WrongSpot, 1),
            new WordleLetter('r', Correctness.WrongSpot, 4),
            new WordleLetter('r', Correctness.WrongSpot, 0),
            new WordleLetter('t', Correctness.Incorrect),
            new WordleLetter('u', Correctness.Incorrect),
            new WordleLetter('i', Correctness.Incorrect),
            new WordleLetter('o', Correctness.Incorrect),
            new WordleLetter('a', Correctness.Incorrect),
            new WordleLetter('s', Correctness.Incorrect),
            new WordleLetter('d', Correctness.Incorrect),
            new WordleLetter('g', Correctness.Incorrect),
            new WordleLetter('h', Correctness.Incorrect),
            new WordleLetter('l', Correctness.Incorrect),
            new WordleLetter('c', Correctness.Incorrect),
            new WordleLetter('n', Correctness.Incorrect),
            new WordleLetter('m', Correctness.Incorrect)
        };

        var possibilities = Solver.Solve(inputs);

        Assert.Contains("every", possibilities);
    }

    [Fact]
    public void MarchTest()
    {
        var inputs = new List<WordleLetter>()
        {
            new WordleLetter('e', Correctness.Incorrect),
            new WordleLetter('r', Correctness.Correct, 2),
            new WordleLetter('t', Correctness.Incorrect),
            new WordleLetter('y', Correctness.Incorrect),
            new WordleLetter('i', Correctness.Incorrect),
            new WordleLetter('o', Correctness.Incorrect),
            new WordleLetter('a', Correctness.Correct, 1),
            new WordleLetter('s', Correctness.Incorrect),
            new WordleLetter('f', Correctness.Incorrect),
            new WordleLetter('h', Correctness.WrongSpot, 0),
            new WordleLetter('k', Correctness.Incorrect),
            new WordleLetter('l', Correctness.Incorrect),
            new WordleLetter('v', Correctness.Incorrect),
            new WordleLetter('b', Correctness.Incorrect),
            new WordleLetter('n', Correctness.Incorrect)
        };

        var possibilities = Solver.Solve(inputs);

        Assert.Contains("march", possibilities);
    }
}
