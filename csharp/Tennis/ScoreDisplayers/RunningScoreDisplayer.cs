namespace Tennis.ScoreDisplayers;

public class RunningScoreDisplayer : IScoreDisplayer
{
    public bool CanDisplay(int p1point, int p2point)
    {
        return p1point == p2point && p1point < 3;
    }

    public string Display(int p1point, int p2point)
    {
        var score = "";
        if (p1point == 0)
            score = "Love";
        if (p1point == 1)
            score = "Fifteen";
        if (p1point == 2)
            score = "Thirty";
        score += "-All";

        return score;
    }
}
