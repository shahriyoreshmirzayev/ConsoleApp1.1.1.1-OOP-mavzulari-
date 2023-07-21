using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1._1._1._1.OOP.OOP_4_dars.Polymorphism_Homework
{
    class Calculator
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static int Sub(int a, int b)
        {
            return a - b;
        }
        public static int Multiply(int a, int b)
        {
            return a * b;
        }
        public static int Div(int a, int b)
        {
            return a / b;
        }
        public static int Abc(int a)
        {
            return Math.Abs(a);
        }
        public static int Pow(int a)
        {
            return (int)Math.Pow(a, 2);
        }
        public void ToString()
        {
            Console.WriteLine($"Yig'indi: {Add}\nAyirma: {Sub}\nKo'paytma: {Multiply}\nBo'linma: {Div}\nModul: {Abc}\nDaraja: {Pow}");
        }
    }
}
