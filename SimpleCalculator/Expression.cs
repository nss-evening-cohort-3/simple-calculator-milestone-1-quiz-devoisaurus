using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace SimpleCalculator
{
    public class Expression
    {
        string pattern = @"^(?<NumOne>-?\d+)\s?(?<Oprtr>[\+\-\*\/%])\s?(?<NumTwo>-?\d+)";

        public void Splitter(string UserInput)
        {
            Regex Regex = new Regex(pattern);

            if (true == Regex.IsMatch(UserInput))
            {

            }

            else

            {
                Console.WriteLine("Invalid input, try something else");
            }

            
        }
    }
}
