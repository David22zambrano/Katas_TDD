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

    [Fact]
    public void Score_Should_Return_FortyLove_When_3_0()
    {
        var calculator = new TennisScoreCalculator();
        var result = calculator.Score(3, 0);
        Assert.Equal("Forty-Love", result);
    }

    [Fact]
    public void Score_Should_Return_Deuce_When_3_3()
    {
        var calculator = new TennisScoreCalculator();
        var result = calculator.Score(3, 3);
        Assert.Equal("Deuce", result);
    }
    
    [Fact]
    public void Score_Should_Return_WinForPlayer1_When_4_0()
    {
        var calculator = new TennisScoreCalculator();
        var result = calculator.Score(4, 0);
        Assert.Equal("Win for Player 1", result);
    }
}

public class TennisScoreCalculator
{
    private readonly string[] scoreNames = { "Love", "Fifteen", "Thirty", "Forty" };

    public string Score(int player1Points, int player2Points)
    {
        // Caso 1: eL jugador gna ( diferencia de al menos puntos 2)
        if (player1Points >= 4 || player2Points >= 4)
        {
            int difference = player1Points - player2Points;

            if (difference >= 2)
                return "Win for Player 1";
            if (difference <= -2)
                return "Win for Player 2";
            if (difference == 1)
                return "Advantage Player 1";
            if (difference == -1)
                return "Advantage Player 2";
        }

        // Caso 2: Deuce (ambos tienen el mismo numero de pubntos  están empatados)
        if (player1Points >= 3 && player2Points >= 3 && player1Points == player2Points)
        {
            return "Deuce";
        }

        // Caso 3: Empate (ambos tienen la misma puntuación < 3)
        if (player1Points == player2Points)
        {
            return $"{scoreNames[player1Points]}-All";
        }

        // Caso 4: Puntuación normal (diferente puntuación)
        return $"{scoreNames[player1Points]}-{scoreNames[player2Points]}";
    }
}