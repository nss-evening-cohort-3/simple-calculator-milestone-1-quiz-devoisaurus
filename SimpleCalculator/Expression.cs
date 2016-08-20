using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class Expression
    {
        public bool Proceed = true;
        List<string> ExitOptions = new List<string>() { "quit", "exit" };
        public string One = "", Two = "", Operator = "";
        List<char> Oprtrs = new List<char>() { '+', '-', '*', '/', '%' };

        public void Splitter(string UserInput)
        {
            if (ExitOptions.Contains(UserInput))
            {
                Proceed = false;
                Environment.Exit(0);
            }

            if (UserInput.StartsWith("-"))
            {
                One = One + "-";
                UserInput = UserInput.Substring(1);

            }
        }
    }
}
