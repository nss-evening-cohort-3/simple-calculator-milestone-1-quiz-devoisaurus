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
        Calculator Calculator = new Calculator();

        public void Splitter(string UserInput)
        {
            Regex Regex = new Regex(pattern);
            Match Matches = Regex.Match(UserInput);

            if (true == Regex.IsMatch(UserInput))
            {
                First = Convert.ToInt32(Matches.Groups["NumOne"].Value);
                Second = Convert.ToInt32(Matches.Groups["NumTwo"].Value);
                Operator = Matches.Groups["Oprtr"].Value;

            }

            else

            {
                Console.WriteLine("Invalid input, try something else");
                Operator = null;
            }
        }
        public void Calc(string Operator)
        {
            if (Operator == "+")
            {
                Console.WriteLine("=: " + Calculator.Add(First, Second));
            }

            else if (Operator == "-")
            {
                Console.WriteLine("=: " + Calculator.Subtract(First, Second));
            }

            else if (Operator == "*")
            {
                Console.WriteLine("=: " + Calculator.Multiply(First, Second));
            }

            else if (Operator == "/")
            {
                if (Second == 0)
                {
                    Console.WriteLine("ERROR 02 DIV BY ZERO");
                }

                else
                {
                    Console.WriteLine("=: " + Calculator.Divide(First, Second));
                }
                
            }

            else if (Operator == "%")
            {
                Console.WriteLine("=: " + Calculator.Modulus(First, Second));
            }

            else if (Operator == null)
            {
                Console.Write("");
            }

                        
        }
    }
}
