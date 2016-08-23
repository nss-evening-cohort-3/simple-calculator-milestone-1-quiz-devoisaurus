using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SimpleCalculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            String prompt1 = "[";
            String prompt2 = "]> ";
            int counter = 0;
            bool Proceed = true;
            List<string> ExitOptions = new List<string>() { "quit", "exit" };

            Expression my_exp = new Expression();
            Calculator my_calc = new Calculator();
            Exits Exits = new Exits();
            Stack Stack = new Stack();


            Console.WriteLine("Welcome! I am a calculator that can handle simple functions such as: addition, subtraction, multiplication, division, and modulus expressions. Try entering an equation and I'll display the answer! If you'd like to see the last equation entered, type 'lasteq'. If you'd like to repeat the last answer, type 'lasta'.  When you are done, type 'exit' or 'quit' to close the program.");
            

            while(Proceed == true)
            {
                Console.Write(prompt1 + counter + prompt2);
                String UserInput = Console.ReadLine().ToLower();
                Exits.Exit(UserInput);
                Stack.LastEq(UserInput);

                if (Stack.DoTheThing == true)
                {
                    Stack.LastAns(UserInput, my_exp.Answer);
                }

                if (Stack.DoTheThing == true)
                {
                    my_exp.Splitter(UserInput);
                    my_exp.Calc(my_exp.Operator, UserInput);
                }
                    counter++;
                    Stack.LastInput = UserInput;
                }
            
            Console.Read();
            



            Console.Write(prompt1 + counter + prompt2);
            Console.Read();



        }
    }
}
