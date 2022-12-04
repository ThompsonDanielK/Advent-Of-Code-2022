using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2022.PuzzleSolvers
{
    public class Puzzle7
    {
        public static int Solve(List<string> puzzleInput)
        {
            int fullyEncompassingPairs = 0;
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

                bool doesPairOneHaveLowest = false;
                bool doesPairOneHaveHighest = false;

                bool doesPairTwoHaveLowest = false;
                bool doesPairTwoHaveHighest = false;

                if (lowHighPairs[0][0] <= lowHighPairs[1][0])
                {
                    doesPairOneHaveLowest = true;
                    if (lowHighPairs[0][0] == lowHighPairs[1][0])
                    {
                        doesPairTwoHaveLowest = true;
                    }
                }
                else
                {
                    doesPairTwoHaveLowest = true;
                }
                if (lowHighPairs[0][1] >= lowHighPairs[1][1])
                {
                    doesPairOneHaveHighest = true;
                    if (lowHighPairs[0][1] == lowHighPairs[1][1])
                    {
                        doesPairTwoHaveHighest = true;
                    }
                }
                else
                {
                    doesPairTwoHaveHighest = true;
                }

                if ((doesPairOneHaveLowest && doesPairOneHaveHighest) || (doesPairTwoHaveHighest && doesPairTwoHaveLowest))
                {
                    fullyEncompassingPairs++;
                }
            }
            return fullyEncompassingPairs;
        }
    }
}
