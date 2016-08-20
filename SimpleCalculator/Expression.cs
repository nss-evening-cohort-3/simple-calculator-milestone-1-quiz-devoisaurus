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

        public int First;
        public int Second;
        public string Operator = "";

        public void Splitter(string UserInput)
        {
            Regex Regex = new Regex(pattern);
            Match Matches = Regex.Match(UserInput);

            Calculator Calculator = new Calculator();

            if (true == Regex.IsMatch(UserInput))
            {
                First = Convert.ToInt32(Matches.Groups["NumOne"].Value);
                Second = Convert.ToInt32(Matches.Groups["NumTwo"].Value);
                Operator = Matches.Groups["Oprtr"].Value;

            }

            else

            {
                Console.WriteLine("Invalid input, try something else");
            }

            if (Operator == "+")
            {
                Console.WriteLine("Answer: " + Calculator.Add(First, Second));
            }

            else if (Operator == "-")
            {
                Console.WriteLine("Answer: " + Calculator.Subtract(First, Second));
            }

            else if (Operator == "*")
            {
                Console.WriteLine("Answer: " + Calculator.Multiply(First, Second));
            }

            else if (Operator == "/")
            {
                if (Second == 0)
                {
                    Console.WriteLine("Division by zero is not an option.");
                }

                else
                {
                    Console.WriteLine("Answer: " + Calculator.Divide(First, Second));
                }
                
            }

            else if (Operator == "%")
            {
                Console.WriteLine("Answer: " + Calculator.Modulus(First, Second));
            }

                        
        }
    }
}
