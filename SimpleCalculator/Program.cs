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
            String prompt2 = "]>";
            int counter = 0;
            bool Proceed = true;
            List<string> Closers = new List<string>() { "quit", "exit" };

            Expression my_exp = new Expression();

            while (Proceed == true)
            { 
            Console.Write(prompt1 + counter + prompt2);
            String userCloseInput = Console.ReadLine().ToLower();

            if (Closers.Contains(userCloseInput))
            {
                    Proceed = false;
                    Console.WriteLine("Bye!");
                    Environment.Exit(0);
            }

        }
    }
}
