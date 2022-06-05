using Tennis.ScoreDisplayers;

namespace Tennis;

public class TennisGame2 : ITennisGame
{
    private static readonly IEnumerable<IScoreDisplayer> ScoreDisplayers = new List<IScoreDisplayer>
    {
        //NOTE(JP): order could be changed to improve performance based on usage data
        new EqualRunningScoreDisplayer(),
        new WinScoreDisplayer(),
        new DeuceScoreDisplayer(),
        new AdvantageScoreDisplayer(),
        new DifferentRunningScoreDisplayer()
    };

    private int p1point;
    private int p2point;

    private readonly string player1Name;
    private readonly string player2Name;

    public TennisGame2(string player1Name, string player2Name)
    {
        this.player1Name = player1Name;
        this.player2Name = player2Name;
    }

    public string GetScore()
    {
        return ScoreDisplayers.Single(x => x.CanDisplay(p1point, p2point)).Display(p1point, p2point);
    }

    public void SetP1Score(int number)
    {
        p1point = number;
    }

    public void SetP2Score(int number)
    {
        p2point = number;
    }

    private void P1Score()
    {
        p1point++;
    }

    private void P2Score()
    {
        p2point++;
    }

    public void WonPoint(string playerName)
    {
        if (playerName == player1Name)
            P1Score();
        else if (playerName == player2Name)
            P2Score();
        else
            throw new ArgumentException($"Player with name {playerName} not found", nameof(playerName));
    }

}

