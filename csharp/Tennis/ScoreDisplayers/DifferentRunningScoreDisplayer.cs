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
            var score = "";
            var p1res = "";
            var p2res = "";
            if (p1point > 0 && p2point == 0)
            {
                if (p1point == 1)
                    p1res = "Fifteen";
                if (p1point == 2)
                    p1res = "Thirty";
                if (p1point == 3)
                    p1res = "Forty";

                p2res = "Love";
                score = p1res + "-" + p2res;
            }
            if (p2point > 0 && p1point == 0)
            {
                if (p2point == 1)
                    p2res = "Fifteen";
                if (p2point == 2)
                    p2res = "Thirty";
                if (p2point == 3)
                    p2res = "Forty";

                p1res = "Love";
                score = p1res + "-" + p2res;
            }

            if (p1point > p2point && p1point < 4)
            {
                if (p1point == 2)
                    p1res = "Thirty";
                if (p1point == 3)
                    p1res = "Forty";
                if (p2point == 1)
                    p2res = "Fifteen";
                if (p2point == 2)
                    p2res = "Thirty";
                score = p1res + "-" + p2res;
            }
            if (p2point > p1point && p2point < 4)
            {
                if (p2point == 2)
                    p2res = "Thirty";
                if (p2point == 3)
                    p2res = "Forty";
                if (p1point == 1)
                    p1res = "Fifteen";
                if (p1point == 2)
                    p1res = "Thirty";
                score = p1res + "-" + p2res;
            }
            return score;
        }
    }
}
