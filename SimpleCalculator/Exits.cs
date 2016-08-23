using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SimpleCalculator
{
    public class Exits
    {
        public bool Exit(string UserInput)
        {
            List<string> ExitOptions = new List<string> { "quit", "exit" };

            if (ExitOptions.Contains(UserInput))
            {
                Console.WriteLine("Have fun stormin' the castle");
                Thread.Sleep(1000);
                Environment.Exit(0);
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}
