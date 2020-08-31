using System.Collections.Generic;

namespace EscapeMines.Models
{
    public class Turtle : Point
    {
        public string Orientation { get; set; }

        public List<string> Moves { get; set; }
    }
}