using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2022.PuzzleSolvers
{
    public static class index
    {
        public static readonly List<string> puzzleSolvers = new List<string>
        {
            "Puzzle 1"
        };

        public static int? PuzzleSelector (int puzzleNumber)
        {
            switch (puzzleNumber)
            {
                case 1:
                    return Puzzle1.Solve();
                    
                default:
                    return null;                   
            }
        }
    }
}
