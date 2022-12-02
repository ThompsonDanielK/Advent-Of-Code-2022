using AdventOfCode2022.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2022.PuzzleSolvers
{
    public static class Puzzle1
    {
        public static int Solve(List<string> puzzleInput)
        {
            int highestTotal = 0;
            int loopTotal = 0;

            for (int i = 0; i < puzzleInput.Count(); i++)
            {
                string line = puzzleInput[i];
                if (line == string.Empty || i == puzzleInput.Count() - 1)
                {
                    if (loopTotal > highestTotal)
                    {

                        highestTotal = loopTotal;
                    }
                    loopTotal = 0;
                }
                int number = InputValidator.ParseStringToInt(line);
                loopTotal += number;
            }

            return highestTotal;
        }
    }
}
