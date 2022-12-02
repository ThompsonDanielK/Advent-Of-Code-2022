using AdventOfCode2022.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileAccess = AdventOfCode2022.Utils.FileAccess;

namespace AdventOfCode2022.PuzzleSolvers
{
    public static class index
    {
        private static List<string> PuzzleInput { get { return RetrievePuzzleInput(); } }

        public static readonly List<string> puzzleSolvers = new List<string>
        {
            "Puzzle 1"
        };

        public static int? PuzzleSelector (int puzzleNumber)
        {
            switch (puzzleNumber)
            {
                case 1:
                    return Puzzle1.Solve(PuzzleInput);
                    
                default:
                    return null;                   
            }
        }

        private static List<string> RetrievePuzzleInput()
        {
            List<string> puzzleInput = FileAccess.ReadPuzzleInput();
            return puzzleInput;
        }
    }
}
