using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasckHome
{
    public class Calculator
    {
        public int Additional(int a, int b) { return a + b; }
        public int Subtraction(int a, int b) { return a - b; }
        public int Multiplication(int a, int b) { return a * b; }
        public int Division(int a, int b) {
            if (b == 0)
                throw new DivideByZeroException("Division by zero is not allowed.");

            return a / b; 
        }
    }
}