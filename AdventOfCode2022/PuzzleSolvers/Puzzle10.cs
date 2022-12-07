using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2022.PuzzleSolvers
{
    public class Puzzle10
    {
        public static string Solve(List<string> puzzleInput)
        {
            string topOfEachColumn = "";

            List<List<string>> inventoryMap = new List<List<string>>();

            bool readingInventoryMap = true;
            for (int i = 0; i < puzzleInput.Count; i++)
            {

                string quantityToMove = "";
                string departingColumn = "";
                string destinationColumn = "";

                for (int q = 0; q < puzzleInput[i].Length; q++)
                {
                    string character = puzzleInput[i][q].ToString();
                    if (int.TryParse(character, out int result))
                    {
                        if (readingInventoryMap)
                        {
                            readingInventoryMap = false;
                            foreach (List<string> line in inventoryMap)
                            {
                                line.Reverse();
                            }
                            break;
                        }
                        else
                        {
                            if (quantityToMove == "")
                            {
                                quantityToMove = character;
                                if (puzzleInput[i].Count() - 1 > q && Char.IsWhiteSpace(puzzleInput[i][q - 1]))
                                {
                                    string nextCharacter = puzzleInput[i][q + 1].ToString();
                                    if (int.TryParse(nextCharacter, out int result3))
                                    {
                                        quantityToMove += nextCharacter;
                                    }
                                }
                            }
                            else if (departingColumn == "" && q > 0 && Char.IsWhiteSpace(puzzleInput[i][q - 1]))
                            {
                                departingColumn = character;
                                if (puzzleInput[i].Count() - 1 > q && puzzleInput[i][q - 1].ToString() == "")
                                {
                                    string nextCharacter = puzzleInput[i][q + 1].ToString();
                                    if (int.TryParse(nextCharacter, out int result3))
                                    {
                                        departingColumn += nextCharacter;
                                        q++;
                                    }
                                }
                            }
                            else if (destinationColumn == "" && q > 0 && Char.IsWhiteSpace(puzzleInput[i][q - 1]))
                            {
                                destinationColumn = character;
                                if (puzzleInput[i].Count() - 1 > q && puzzleInput[i][q - 1].ToString() == "")
                                {
                                    string nextCharacter = puzzleInput[i][q + 1].ToString();
                                    if (int.TryParse(nextCharacter, out int result3))
                                    {
                                        destinationColumn += nextCharacter;
                                    }
                                }
                            }


                        }
                    }
                    else if (readingInventoryMap)
                    {
                        if (character != " " && character != "[" && character != "]")
                        {
                            int columnNumber = 0;
                            if (q > 1)
                            {
                                columnNumber = (q - 1) / 4;
                            }
                            if (inventoryMap.Count - 1 < columnNumber)
                            {
                                for (int r = 0; r <= columnNumber; r++)
                                {
                                    if (r + 1 > inventoryMap.Count())
                                    {
                                        inventoryMap.Add(new List<string>());
                                    }

                                }
                                inventoryMap[columnNumber].Add(character);
                            }
                            else
                            {
                                inventoryMap[columnNumber].Add(character);
                            }
                        }
                    }
                }

                if (quantityToMove != "" && !readingInventoryMap)
                {
                    int parsedQuantityToMove = int.Parse(quantityToMove);
                    int parsedDepartingColumn = int.Parse(departingColumn);
                    int parsedDestinationColumn = int.Parse(destinationColumn);

                    int departingColumnCount = inventoryMap[parsedDepartingColumn - 1].Count();
                    for (int q = 0; q < parsedQuantityToMove; q++)
                    {

                        Dictionary<int, List<string>> columnNumberToList = new Dictionary<int, List<string>>();
                        for (int s = 0; s < inventoryMap.Count(); s++)
                        {
                            columnNumberToList.Add(s + 1, inventoryMap[s]);
                        }

                        columnNumberToList[parsedDestinationColumn].Add(columnNumberToList[parsedDepartingColumn][columnNumberToList[parsedDepartingColumn].Count() - (parsedQuantityToMove - q)]);
                        columnNumberToList[parsedDepartingColumn].RemoveAt(columnNumberToList[parsedDepartingColumn].Count() - (parsedQuantityToMove - q));
                    }
                }
            }

            foreach (List<string> column in inventoryMap)
            {
                topOfEachColumn += column[column.Count() - 1];
            }

            return topOfEachColumn;
        }
    }
}
