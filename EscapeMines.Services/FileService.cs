using System.Collections.Generic;
using System.IO;
using System.Linq;
using EscapeMines.Models;

namespace EscapeMines.Services
{
    public static class FileService
    {
        public static (Point, List<Mine>, ExitPoint, Turtle) ReadFromFile()
        {
            var lines = File.ReadAllLines(@"C:\Users\Catalin Hotea\source\repos\EscapeMines\input.txt");

            var boardSizes = lines[0].Split(' ');

            var board = new Point
            {
                X = int.Parse(boardSizes[0]),
                Y = int.Parse(boardSizes[1])
            }; 
            
            var rawMines = lines[1].Split(' ').ToList();

            var mines = rawMines.Select(mine =>
            {
                var parsedMine = mine.Split(',');
                return new Mine
                {
                    X = int.Parse(parsedMine[0]),
                    Y = int.Parse(parsedMine[1])
                };
            }).ToList();

            var rawExitPoint = lines[2].Split(' ').Select(int.Parse).ToList();

            var exitPoint = new ExitPoint
            {
                X = rawExitPoint[0],
                Y = rawExitPoint[1]
            };

            var turtleStartPoint = lines[3].Split(' ').ToList();

            var moves = lines[4].Split(' ').ToList().Concat(lines[5].Split(' ').ToList()).ToList();

            var turtle = new Turtle
            {
                X = int.Parse(turtleStartPoint[0]),
                Y = int.Parse(turtleStartPoint[1]),
                Orientation = turtleStartPoint[2],
                Moves = moves
            };

            return (board, mines, exitPoint, turtle);
        }
    }
}