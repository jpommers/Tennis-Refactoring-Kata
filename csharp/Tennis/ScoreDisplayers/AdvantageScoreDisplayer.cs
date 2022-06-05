namespace Tennis.ScoreDisplayers;

public class AdvantageScoreDisplayer : IScoreDisplayer
{
    private const string P1WinScore = "Advantage player1";
    private const string P2WinScore = "Advantage player2";

    public bool CanDisplay(int p1point, int p2point)
    {
        return Math.Min(p1point, p2point) >= 3 && Math.Abs(p1point - p2point) == 1;
    }

    public string Display(int p1point, int p2point)
    {
        return (p1point > p2point) ? P1WinScore : P2WinScore;
    }
}
