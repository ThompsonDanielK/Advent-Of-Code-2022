using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2022.PuzzleSolvers
{
    public class Puzzle12
    {
        public static string Solve(List<string> puzzleInput)
        {
            for (int i = 0; i < puzzleInput.Count(); i++)
            {
                string line = puzzleInput[i];
                for (int q = 13; q < line.Length; q++)
                {
                    string groupOfFour = line.Substring(q - 13, 14);

                    List<string> groupOfFourList = new List<string>();

                    for (int r = 0; r < groupOfFour.Length; r++)
                    {
                        groupOfFourList.Add(groupOfFour[r].ToString());
                    }

                    if (groupOfFourList.Distinct().Count() == groupOfFour.Count())
                    {
                        return (q + 1).ToString();
                    }
                }
            }
            return "";
        }
    }
}
