using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2022.PuzzleSolvers
{
    public static class Puzzle5
    {
        public static int Solve(List<string> puzzleInput)
        {
            int sumOfPrioties = 0;
            for (int i = 0; i < puzzleInput.Count(); i++)
            {
                int puzzleInputLineLength = puzzleInput[i].Count();

                string firstBucket = puzzleInput[i].Substring(0, puzzleInputLineLength / 2);
                string secoundBucket = puzzleInput[i].Substring(puzzleInputLineLength / 2, puzzleInputLineLength / 2);

                var matchingChars = firstBucket.Intersect(secoundBucket);
                foreach (char character in matchingChars)
                {
                    int priority = 0;
                    int ASCII = character;
                    if (Char.IsUpper(character))
                    {
                        priority += ASCII - 38;
                    }
                    else
                    {
                        priority += ASCII - 96;
                    }
                    sumOfPrioties += priority;
                }
            }
            return sumOfPrioties;
        }
    }
}
