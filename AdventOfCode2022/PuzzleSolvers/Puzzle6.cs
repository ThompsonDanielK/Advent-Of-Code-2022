using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2022.PuzzleSolvers
{
    public static class Puzzle6
    {
        public static int Solve(List<string> puzzleInput)
        {
            int sumOfPrioties = 0;
            List<List<string>> groupsOfThree = groupStringsInThrees(puzzleInput);
            foreach (List<string> group in groupsOfThree)
            {
                var matchingChars = group[0].Intersect(group[1]).Intersect(group[2]);
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

        private static List<List<string>> groupStringsInThrees(List<string> stringList)
        {
            List<List<string>> result = new List<List<string>>();
            for (int i = 0; i < stringList.Count(); i += 3)
            {
                List<string> groupOfThree = new List<string>()
                {
                    stringList[i],
                    stringList[i + 1],
                    stringList[i + 2]
                };
                result.Add(groupOfThree);
            }
            return result;
        }
    }
}
