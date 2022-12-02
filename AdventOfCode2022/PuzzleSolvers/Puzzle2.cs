using AdventOfCode2022.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2022.PuzzleSolvers
{
    public static class Puzzle2
    {
        public static int Solve(List<string> puzzleInput)
        {
            List<int> highestTotal = new List<int>()
            {
                0, 0, 0
            };
            int loopTotal = 0;

            for (int i = 0; i < puzzleInput.Count(); i++)
            {
                string line = puzzleInput[i];
                if (line != String.Empty)
                {
                    int lineConvertedToInt = InputValidator.ParseStringToInt(line);
                    loopTotal += lineConvertedToInt;
                }
                if (i == puzzleInput.Count() - 1 || line == String.Empty)
                {
                    highestTotal.Sort();
                    for (int t = 0; t < highestTotal.Count(); t++)
                    {
                        if (loopTotal > highestTotal[t])
                        {

                            highestTotal[t] = loopTotal;
                            break;
                        }
                    }
                    loopTotal = 0;
                }
            }

            return highestTotal.Sum();
        }
    }
}
