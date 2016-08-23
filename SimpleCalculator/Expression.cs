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
        public int Answer;
        Calculator Calculator = new Calculator();
        Stack Stack = new Stack();

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

            else if (false == Regex.IsMatch(UserInput))

            {
                Console.WriteLine("Invalid input, try something else");
                Operator = null;
            }
        }
        public void Calc(string Operator, string UserInput)
        {
            if (Operator == "+")
            {
                Answer = Calculator.Add(First, Second);
                Console.WriteLine("=: " + Answer);
                Stack.LastAns(UserInput, Answer);

            }

            else if (Operator == "-")
            {
                Answer = Calculator.Subtract(First, Second);
                Console.WriteLine("=: " + Answer);
                Stack.LastAns(UserInput, Answer);
            }

            else if (Operator == "*")
            {
                Answer = Calculator.Multiply(First, Second);
                Console.WriteLine("=: " + Answer);
                Stack.LastAns(UserInput, Answer);
            }

            else if (Operator == "/")
            {
                if (Second == 0)
                {
                    Console.WriteLine("ERROR 02 DIV BY ZERO");
                }

                else
                {
                    Answer = Calculator.Divide(First, Second);
                    Console.WriteLine("=: " + Answer);
                    Stack.LastAns(UserInput, Answer);
                }
                
            }

            else if (Operator == "%")
            {
                Answer = Calculator.Modulus(First, Second);
                Console.WriteLine("=: " + Answer);
                Stack.LastAns(UserInput, Answer);
            }

            else if (Operator == null)
            {
                Console.Write("");
            }

                        
        }
    }
}
