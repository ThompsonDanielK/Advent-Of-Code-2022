using AdventOfCode2022.PuzzleSolvers;
using AdventOfCode2022.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2022
{
    public class UserInterface
    {
        public void Run()
        {
            Console.WriteLine("  ______         __                                  __                       ______          ______                   __\r\n" +
                              " /      \\       |  \\                                |  \\                     /      \\        /      \\                 |  \\\r\n" +
                              "|  $$$$$$\\  ____| $$ __     __   ______   _______  _| $$_           ______  |  $$$$$$\\      |  $$$$$$\\  ______    ____| $$  ______\r\n" +
                              "| $$__| $$ /      $$|  \\   /  \\ /      \\ |       \\|   $$ \\         /      \\ | $$_  \\$$      | $$   \\$$ /      \\  /      $$ /      \\\r\n" +
                              "| $$    $$|  $$$$$$$ \\$$\\ /  $$|  $$$$$$\\| $$$$$$$\\\\$$$$$$        |  $$$$$$\\| $$ \\          | $$      |  $$$$$$\\|  $$$$$$$|  $$$$$$\r\n" +
                              "| $$$$$$$$| $$  | $$  \\$$\\  $$ | $$    $$| $$  | $$ | $$ __       | $$  | $$| $$$$          | $$   __ | $$  | $$| $$  | $$| $$    $$\r\n" +
                              "| $$  | $$| $$__| $$   \\$$ $$  | $$$$$$$$| $$  | $$ | $$|  \\      | $$__/ $$| $$            | $$__/  \\| $$__/ $$| $$__| $$| $$$$$$$$\r\n" +
                              "| $$  | $$ \\$$    $$    \\$$$    \\$$     \\| $$  | $$  \\$$  $$       \\$$    $$| $$             \\$$    $$ \\$$    $$ \\$$    $$ \\$$\r\n" +
                              " \\$$   \\$$  \\$$$$$$$     \\$      \\$$$$$$$ \\$$   \\$$   \\$$$$         \\$$$$$$  \\$$              \\$$$$$$   \\$$$$$$   \\$$$$$$$  \\$$$$$$$");

            Console.WriteLine();
            Console.WriteLine("These are the availabe puzzle solvers.");
            Console.WriteLine();

            for (int i = 0; i < index.puzzleSolvers.Count; i++)
            {
                Console.WriteLine($"{i+1}) {index.puzzleSolvers[i]}");
            }

            bool puzzleInputLoop = true;
            while (puzzleInputLoop)
            {
                Console.WriteLine();
                Console.WriteLine("Please input the number of the puzzle that you want to solve.");

                string? userInput = Console.ReadLine();
                int puzzleNumber = InputValidator.inputValidator(userInput);
                if (puzzleNumber > index.puzzleSolvers.Count || puzzleNumber < 1)
                {
                    Console.WriteLine("Please input a valid puzzle number.");
                }
                else
                {
                    int? result = index.PuzzleSelector(puzzleNumber);
                    puzzleInputLoop = false;
                    Console.WriteLine($"The result is {result}");
                }
            }

        }
    }
}
