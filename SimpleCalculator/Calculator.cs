using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class Calculator
    {
        public int Add(int First, int Second)
        {
            return First + Second;
        }

        public int Subtract(int First, int Second)
        {
            return First - Second;
        }

        public int Multiply(int First, int Second)
        {
            return First * Second;
        }

        public int Divide(int First, int Second)
        {
            if (Second == 0)
            {
                Console.WriteLine("Nope, divding by 0 isn't possible.");
                return 0;
            }

            else
            {
                return First / Second;
            }
            
        }

        public int Modulus(int First, int Second)
        {
            return First % Second;
        }
    }
}
