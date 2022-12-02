using System;
using System.Collections.Generic;
using System.IO;
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
        private static string FilePath { get { return DirectoryInformation.TryGetSolutionDirectoryInfo().Parent.FullName; } set { } }

        /// <summary>
        /// Reads puzzle input from file
        /// </summary>
        public static List<string> ReadPuzzleInput()
        {
            List<string> puzzleInput = new List<string>();
            try
            {
                using (StreamReader reader = new StreamReader(Path.Combine(FilePath, "puzzleInput.txt")))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        puzzleInput.Add(line);
                    }
                }
            }
            catch (IOException exc)
            {
                Console.WriteLine("There was an error loading the puzzleInput file.");
            }
            return puzzleInput;
        }
    }
}
