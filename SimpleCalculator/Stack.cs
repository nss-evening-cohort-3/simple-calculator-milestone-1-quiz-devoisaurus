using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace SimpleCalculator
{
    public class Stack
    {
        public string LastInput;
        public bool DoTheThing = true;

        public void LastEq(string UserInput)
        {
            if (UserInput == "lasteq")
            {
                Console.WriteLine(LastInput);
                DoTheThing = false;
            }

            else
            {
                DoTheThing = true;
            }
        }
    }
}
