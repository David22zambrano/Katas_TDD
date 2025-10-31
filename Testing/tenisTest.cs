namespace Testing;

public class TennisScoreCalculatorTests
{
// FAse RED
    [Fact]
    public void Score_Should_Return_LoveAll_When_0_0()
    {
        var calculator = new TennisScoreCalculator();
        var result = calculator.Score(0, 0);
        Assert.Equal("Love-All", result);
    }

    [Fact]
    public void Score_Should_Return_FifteenLove_When_1_0()
    {
        var calculator = new TennisScoreCalculator();
        var result = calculator.Score(1, 0);
        Assert.Equal("Fifteen-Love", result);
    }

    [Fact]
    public void Score_Should_Return_LoveFifteen_When_0_1()
    {
        var calculator = new TennisScoreCalculator();
        var result = calculator.Score(0, 1);
        Assert.Equal("Love-Fifteen", result);
    }

    [Fact]
    public void Score_Should_Return_ThirtyFifteen_When_2_1()
    {
        var calculator = new TennisScoreCalculator();
        var result = calculator.Score(2, 1);
        Assert.Equal("Thirty-Fifteen", result);
    }
}

public class TennisScoreCalculator
{
    public string Score(int player1Points, int player2Points)
    {
        if (player1Points == 0 && player2Points == 0)
        {
            return "Love-All";
        }

        if (player1Points == 1 && player2Points == 0)
        {
            return "Fifteen-Love";
        }

        if (player1Points == 0 && player2Points == 1)
        {
            return "Love-Fifteen";
        }

        if (player1Points == 2 && player2Points == 1)
        {
            return "Thirty-Fifteen";
        }

        return string.Empty;
    }
}