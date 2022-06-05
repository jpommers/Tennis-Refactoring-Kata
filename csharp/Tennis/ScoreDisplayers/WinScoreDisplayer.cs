namespace Tennis.ScoreDisplayers;

public class WinScoreDisplayer : IScoreDisplayer
{
    public bool CanDisplay(int p1point, int p2point)
    {
        return Math.Max(p1point, p2point) >= 4 && Math.Abs(p1point - p2point) >= 2;
    }

    public string Display(int p1point, int p2point)
    {
        if(p1point > p2point)
        {
            return "Win for player1";
        } else
        {
            return "Win for player2";
        }
    }
}
