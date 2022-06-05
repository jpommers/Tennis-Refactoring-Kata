namespace Tennis.ScoreDisplayers;

public class AdvantageScoreDisplayer : IScoreDisplayer
{
    public bool CanDisplay(int p1point, int p2point)
    {
        return Math.Min(p1point, p2point) >= 3 && Math.Abs(p1point - p2point) == 1;
    }

    public string Display(int p1point, int p2point)
    {
        if(p1point > p2point)
        {
            return "Advantage player1";
        } else
        {
            return "Advantage player2";
        }
    }
}
