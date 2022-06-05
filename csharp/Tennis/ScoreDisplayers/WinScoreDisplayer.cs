namespace Tennis.ScoreDisplayers;

public class WinScoreDisplayer : IScoreDisplayer
{
    private const string Player1WinScore = "Win for player1";
    private const string Player2WinScore = "Win for player2";

    public bool CanDisplay(int p1point, int p2point)
    {
        return Math.Max(p1point, p2point) >= 4 && Math.Abs(p1point - p2point) >= 2;
    }

    public string Display(int p1point, int p2point)
    {
        return (p1point > p2point) ? Player1WinScore : Player2WinScore;
    }
}
