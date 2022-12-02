using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2022.PuzzleSolvers
{
    public static class Puzzle3
    {
        private static IDictionary<string, int> letterValues 
        {
            get
            {
                return new Dictionary<string, int>()
                {
                    {"X", 1},
                    {"Y", 2},
                    {"Z", 3}
                };

            }
            
            set { } 
        }

        private static IDictionary<string, string> letterWinLosePairs
        {
            get
            {
                return new Dictionary<string, string>()
                {
                    {"X", "C"},
                    {"Y", "A"},
                    {"Z", "B"}
                };

            }

            set { }
        }

        private static IDictionary<string, string> letterDrawPairs
        {
            get
            {
                return new Dictionary<string, string>()
                {
                    {"X", "A"},
                    {"Y", "B"},
                    {"Z", "C"}
                };

            }

            set { }
        }





        public static int Solve(List<string> puzzleInput)
        {
            int totalScore = 0;
            foreach (string line in puzzleInput)
            {
                string[] splitLine = line.Split(' ');
                string opponentLetter = splitLine[0];
                string playerLetter = splitLine[1];
                totalScore += letterValues[playerLetter];

                if (letterDrawPairs[playerLetter] == opponentLetter)
                {
                    totalScore += 3;
                }
                else if (letterWinLosePairs[playerLetter] == opponentLetter)
                {
                    totalScore += 6;
                }

            }
            return totalScore;
        }
    }
}
