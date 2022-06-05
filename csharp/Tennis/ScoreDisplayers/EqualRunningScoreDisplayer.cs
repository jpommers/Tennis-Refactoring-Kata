namespace Tennis.ScoreDisplayers;

public class EqualRunningScoreDisplayer : IScoreDisplayer
{
    private const string AllScorePostfix = "All";

    public bool CanDisplay(int p1point, int p2point)
    {
        return p1point == p2point && p1point < 3;
    }

    public string Display(int p1point, int p2point)
    {
        return $"{ScoreDisplayConstants.PointNameMap[p1point]}-{AllScorePostfix}";
    }
}
