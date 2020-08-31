using EscapeMines.Models;
using System.Collections.Generic;
using System.Linq;

namespace EscapeMines.Common.Helpers
{
    public static class MineHelper
    {
        public static string GetLeftOrientation(int currentPos)
        {
            if (currentPos == 0)
                return "W";

            return Constants.CardinalPoints.ElementAtOrDefault((currentPos + 1) % 4);
        }

        public static bool IsMoveIncorrect(List<Mine> mines, int i, int j)
        {
            return mines.Any(m => m.X == i && m.Y == j);
        }

        public static bool IsFinishPoint(ExitPoint point, int i, int j)
        {
            return point.X == i && point.Y == j;
        }
    }
}