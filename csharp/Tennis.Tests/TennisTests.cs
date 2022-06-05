using System;
using System.Collections;
using System.Collections.Generic;
using Xunit;

namespace Tennis.Tests;

public class TestDataGenerator : IEnumerable<object[]>
{
    //NOTE(JP): not completely clear about expected output when providing custom player name
    //Does player1 imply it is the first player or that the players name is "player1"?
    //assuming it' s the first case for now
    private readonly List<object[]> _data = new List<object[]>
    {
        new object[] {0, 0, "Love-All"},
        new object[] {1, 1, "Fifteen-All"},
        new object[] {2, 2, "Thirty-All"},
        new object[] {3, 3, "Deuce"},
        new object[] {4, 4, "Deuce"},
        new object[] {1, 0, "Fifteen-Love"},
        new object[] {0, 1, "Love-Fifteen"},
        new object[] {2, 0, "Thirty-Love"},
        new object[] {0, 2, "Love-Thirty"},
        new object[] {3, 0, "Forty-Love"},
        new object[] {0, 3, "Love-Forty"},
        new object[] {4, 0, "Win for player1"},
        new object[] {0, 4, "Win for player2"},
        new object[] {2, 1, "Thirty-Fifteen"},
        new object[] {1, 2, "Fifteen-Thirty"},
        new object[] {3, 1, "Forty-Fifteen"},
        new object[] {1, 3, "Fifteen-Forty"},
        new object[] {4, 1, "Win for player1"},
        new object[] {1, 4, "Win for player2"},
        new object[] {3, 2, "Forty-Thirty"},
        new object[] {2, 3, "Thirty-Forty"},
        new object[] {4, 2, "Win for player1"},
        new object[] {2, 4, "Win for player2"},
        new object[] {4, 3, "Advantage player1"},
        new object[] {3, 4, "Advantage player2"},
        new object[] {5, 4, "Advantage player1"},
        new object[] {4, 5, "Advantage player2"},
        new object[] {15, 14, "Advantage player1"},
        new object[] {14, 15, "Advantage player2"},
        new object[] {6, 4, "Win for player1"},
        new object[] {4, 6, "Win for player2"},
        new object[] {16, 14, "Win for player1"},
        new object[] {14, 16, "Win for player2"},
    };

    public IEnumerator<object[]> GetEnumerator() => _data.GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}

public class TennisTests
{

    [Theory]
    [ClassData(typeof(TestDataGenerator))]
    public void Tennis2Test(int p1, int p2, string expected)
    {
        var random = new Random();
        var player1Name = "player1" + random.Next(0, 1000);
        var player2Name = "player2" + random.Next(0, 1000);
        var game = new TennisGame2(player1Name, player2Name);
        CheckAllScores(game, player1Name, player2Name, p1, p2, expected);
    }

    private void CheckAllScores(ITennisGame game, string player1Name, string player2Name, int player1Score, int player2Score, string expectedScore)
    {
        var highestScore = Math.Max(player1Score, player2Score);
        for (var i = 0; i < highestScore; i++)
        {
            if (i < player1Score)
                game.WonPoint(player1Name);
            if (i < player2Score)
                game.WonPoint(player2Name);
        }

        Assert.Equal(expectedScore, game.GetScore());
    }
}