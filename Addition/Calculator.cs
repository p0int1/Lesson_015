using System;

namespace Addition
{
    public class Calculator
    {
        // арифметические операции
        public double Add(int a, int b)
        {
            return (a + b);
        }
        public double Sub(int a, int b)
        {
            return (a - b);
        }
        public double Mul(int a, int b)
        {
            return (a * b);
        }
        public double Div(int a, int b)
        {
            if (b == 0)
               throw new Exception("Попытка деления на ноль");
           
            return (a / b);
        }
    }
}
