namespace Tennis.ScoreDisplayers;

public class DeuceScoreDisplayer : IScoreDisplayer
{
    public bool CanDisplay(int p1point, int p2point)
    {
        return p1point == p2point && p1point > 2;
    }

    public string Display(int p1point, int p2point)
    {
        return "Deuce";
    }
}
