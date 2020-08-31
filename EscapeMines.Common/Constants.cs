using System.Collections.Generic;

namespace EscapeMines.Common
{
    public static class Constants
    {
        public static List<string> CardinalPoints = new List<string>
        {
            "N",
            "E",
            "S",
            "W"
        };

        public static string OutOfTable = "Out of table!";
        public static string MineHit = "Mine hit!";
        public static string Success = "Success!";
        public static string Danger = "Still in Danger!";
    }
}