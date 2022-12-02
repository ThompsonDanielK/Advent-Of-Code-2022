using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2022.PuzzleSolvers
{
    public static class Puzzle4
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

        private static IDictionary<string, string> letterLoseWinPairs
        {
            get
            {
                return new Dictionary<string, string>()
                {
                    {"X", "B"},
                    {"Y", "C"},
                    {"Z", "A"}
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

        private static IDictionary<string, Func<string, string>> letterStrategyPairs
        {
            get
            {
                return new Dictionary<string, Func<string, string>>()
                {
                    {"X", makeLoss},
                    {"Y", makeDraw},
                    {"Z", makeVictory}
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
                playerLetter = letterStrategyPairs[playerLetter](opponentLetter);
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

        private static string makeDraw(string opponentLetter)
        {
            return letterDrawPairs.FirstOrDefault(x => x.Value == opponentLetter).Key;
        }

        private static string makeLoss(string opponentLetter)
        {
            return letterLoseWinPairs.FirstOrDefault(x => x.Value == opponentLetter).Key;
        }

        private static string makeVictory(string opponentLetter)
        {
            return letterWinLosePairs.FirstOrDefault(x => x.Value == opponentLetter).Key;
        }
    }
}

