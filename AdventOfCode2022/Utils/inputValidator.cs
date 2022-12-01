using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2022.Utils
{
    public static class InputValidator
    {
        public static int inputValidator(string? input)
        {
            int intInput = 0;
            bool result = int.TryParse(input, out intInput);

            return intInput;
        }
    }
}
