using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            

            while(Proceed == true)
            {
                Console.Write(prompt1 + counter + prompt2);
                String UserInput = Console.ReadLine().ToLower();

                if(ExitOptions.Contains(UserInput))
                {
                    Proceed = false;
                    Console.WriteLine("Have fun stormin' the castle");
                    Environment.Exit(0);
                }
                counter++;
                my_exp.Splitter(UserInput);
            }

            Console.Read();
            



            Console.Write(prompt1 + counter + prompt2);
            Console.Read();



        }
    }
}
