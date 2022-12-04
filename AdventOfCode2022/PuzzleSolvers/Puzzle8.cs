using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2022.PuzzleSolvers
{
    internal class Puzzle8
    {
        public static int Solve(List<string> puzzleInput)
        {
            int encompassingPairs = 0;
            for (int i = 0; i < puzzleInput.Count(); i++)
            {
                List<List<int>> lowHighPairs = new List<List<int>>();
                string[] pairs = puzzleInput[i].Split(",");
                foreach (string pair in pairs)
                {
                    string[] highLowPair = pair.Split("-");
                    int[] intHighLowPair = Array.ConvertAll(highLowPair, s => int.Parse(s));
                    Array.Sort(intHighLowPair);
                    lowHighPairs.Add(intHighLowPair.ToList());
                }

                int pairOneLow = lowHighPairs[0][0];
                int pairOneHigh = lowHighPairs[0][1];
                int pairTwoLow = lowHighPairs[1][0];
                int pairTwoHigh = lowHighPairs[1][1];
                if (
                    (pairOneLow == pairTwoLow) || (pairOneLow == pairTwoHigh) ||
                    (pairOneHigh == pairTwoLow) || (pairOneHigh == pairTwoHigh)
                )
                {
                    encompassingPairs++;
                }
                else if ((pairOneLow <= pairTwoLow) && (pairOneHigh >= pairTwoLow))
                {
                    encompassingPairs++;
                }
                else if ((pairOneLow >= pairTwoLow) && (pairTwoHigh >= pairOneLow))
                {
                    encompassingPairs++;
                }

            }
            return encompassingPairs;
        }
    }
}
