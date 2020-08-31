using EscapeMines.Common;
using EscapeMines.Common.Helpers;
using System;
using System.Linq;

namespace EscapeMines.Services
{
    public static class MineService
    {
        public static void EscapeMines()
        {
            var (board, mines, exitPoint, turtle) = FileService.ReadFromFile();

            var i = turtle.X;
            var j = turtle.Y;
            var moves = turtle.Moves;

            foreach (var move in moves)
            {
                if (i > board.X && j > board.Y)
                {
                    Console.WriteLine(Constants.OutOfTable);
                    return;
                }

                switch (move)
                {
                    case "R":
                        var currentPos = Constants.CardinalPoints.IndexOf(turtle.Orientation);

                        turtle.Orientation = Constants.CardinalPoints.ElementAtOrDefault((currentPos + 1) % 4);

                        break;
                    case "L":
                        var currentPosition = Constants.CardinalPoints.IndexOf(turtle.Orientation);

                        turtle.Orientation = MineHelper.GetLeftOrientation(currentPosition);

                        break;
                    case "M":
                        switch (turtle.Orientation)
                        {
                            case "N":
                                i -= 1;
                                break;
                            case "S":
                                i += 1;
                                break;
                            case "W":
                                j -= 1;
                                break;
                            case "E":
                                j += 1;
                                break;
                        }
                        break;
                    case "N":
                        turtle.Orientation = move;
                        break;
                    case "S":
                        turtle.Orientation = move;
                        break;
                    case "W":
                        turtle.Orientation = move;
                        break;
                    case "E":
                        turtle.Orientation = move;
                        break;
                }

                if (MineHelper.IsMoveIncorrect(mines, i, j))
                {
                    Console.WriteLine(Constants.MineHit);
                    return;
                }

                if (MineHelper.IsFinishPoint(exitPoint, i, j))
                {
                    Console.WriteLine(Constants.Success);
                    return;
                }

                Console.WriteLine(Constants.Danger);
            }
        }
    }
}