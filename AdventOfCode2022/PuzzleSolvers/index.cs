using FileAccess = AdventOfCode2022.Utils.FileAccess;

namespace AdventOfCode2022.PuzzleSolvers
{
    public static class index
    {
        private static List<string> PuzzleInput { get { return RetrievePuzzleInput(); } }

        public static readonly List<string> puzzleSolvers = new List<string>
        {
            "Puzzle 1",
            "Puzzle 2",
            "Puzzle 3",
            "Puzzle 4",
            "Puzzle 5",
            "Puzzle 6",
            "Puzzle 7",
            "Puzzle 8",
            "Puzzle 9",
            "Puzzle 10"
        };

        public static string PuzzleSelector (int puzzleNumber)
        {
            switch (puzzleNumber)
            {
                case 1:
                    return Puzzle1.Solve(PuzzleInput).ToString();
                case 2:
                    return Puzzle2.Solve(PuzzleInput).ToString();
                case 3:
                    return Puzzle3.Solve(PuzzleInput).ToString();
                case 4:
                    return Puzzle4.Solve(PuzzleInput).ToString();
                case 5:
                    return Puzzle5.Solve(PuzzleInput).ToString();
                case 6:
                    return Puzzle6.Solve(PuzzleInput).ToString();
                case 7:
                    return Puzzle7.Solve(PuzzleInput).ToString();
                case 8:
                    return Puzzle8.Solve(PuzzleInput).ToString();
                case 9:
                    return Puzzle9.Solve(PuzzleInput);
                case 10:
                    return Puzzle10.Solve(PuzzleInput);

                default:
                    return null;                   
            }
        }

        private static List<string> RetrievePuzzleInput()
        {
            List<string> puzzleInput = FileAccess.ReadPuzzleInput();
            return puzzleInput;
        }
    }
}
