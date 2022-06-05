namespace Tennis.ScoreDisplayers;

public static class ScoreDisplayConstants
{
    public static IDictionary<int, string> PointNameMap { get; set; } = new Dictionary<int, string>
        {
            { 0, "Love" },
            { 1, "Fifteen" },
            { 2, "Thirty" },
            { 3, "Forty" }
        };
}