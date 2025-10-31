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
  }

  public class TennisScoreCalculator
  {
      public string Score(int player1Points, int player2Points)
      {
          return "Love-All";
      }
  }