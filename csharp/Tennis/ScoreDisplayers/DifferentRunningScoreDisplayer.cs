namespace Tennis.ScoreDisplayers
{
    internal class DifferentRunningScoreDisplayer : IScoreDisplayer
    {
        public bool CanDisplay(int p1point, int p2point)
        {
            return Math.Max(p1point, p2point) <=3 && p1point != p2point;
        }

        public string Display(int p1point, int p2point)
        {
            return $"{ScoreDisplayConstants.PointNameMap[p1point]}-{ScoreDisplayConstants.PointNameMap[p2point]}";
        }
    }
}
