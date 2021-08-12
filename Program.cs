using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Calculator
    {
        public void Add(int a, int b)
        {
            int c = a + b;
            Console.WriteLine("sum of {0} , {1} is {2}", a, b, c);
        }
        public void Sub(int a, int b)
        {
            int c = a - b;
            Console.WriteLine("Difference of {0} * {1} is {2}", a, b, c);
        }
        public void Mul(int a, int b)
        {
            int c = a * b;
            Console.WriteLine("Product of {0} , {1} is {2}", a, b, c);
        }
        public void Div(int a, int b)
        {
            int c = a / b;
            Console.WriteLine("Division of {0} by {1} is {2}", a, b, c);
        }
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Enter two numbers ");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            Calculator obj = new Calculator();
            obj.Add(a,b);
            obj.Div(a,b);
            obj.Mul(a,b);
            obj.Sub(a,b);

        }

    }
}