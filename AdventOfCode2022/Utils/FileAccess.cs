using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2022.Utils
{
    /// <summary>
    /// This class should contain any and all details of access to files
    /// </summary>
    public static class FileAccess
    {
        // All external data files for this application should live in this directory.
        private static string filePath = @"C:\AdventOfCode2022\";

        /// <summary>
        /// Reads puzzle input from file
        /// </summary>
        public static List<List<string>> ReadPuzzleInput()
        {
            List<List<string>> input = new List<List<string>>();
            try
            {
                using (StreamReader reader = new StreamReader(Path.Combine(filePath, "puzzleInput.csv")))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        // Do something
                    }
                }
                return input;
            }
            catch (IOException exc)
            {
                Console.WriteLine("There was an error loading the puzzleInput file.");
                return input;
            }
        }
    }
}
