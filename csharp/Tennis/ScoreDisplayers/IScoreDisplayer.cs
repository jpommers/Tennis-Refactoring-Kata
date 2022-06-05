namespace Tennis.ScoreDisplayers;

public interface IScoreDisplayer
{
    bool CanDisplay(int p1point, int p2point);
    string Display(int p1point, int p2point);
}
