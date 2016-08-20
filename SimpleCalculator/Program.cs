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

            Console.Write(prompt1 + counter + prompt2);
            String UserInput = Console.ReadLine.ToLower();
            counter++;
            Console.WriteLine(UserInput);
            my_exp.Splitter(UserInput);



            Console.Write(prompt1 + counter + prompt2);
            Console.Read;
                
           

        }
    }
}
