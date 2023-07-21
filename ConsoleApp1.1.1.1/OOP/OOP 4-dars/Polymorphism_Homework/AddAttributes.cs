using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1._1._1._1.OOP.OOP_4_dars.Polymorphism_Homework
{
    class AddAttributes
    {
        public int Qoshish(int num1, int num2)
        {
            return num1 + num2;
        }

        public double Qoshish1(int num1, double num2)
        {
            return num1 + num2;
        }
        public double Qoshish3(double num1, double num2, double num3)
        {
            return num1 + num2 + num3;
        }
        public string Qoshish4(string str1, string str2)
        {
            return str1 + str2;
        }
        public string Qoshish5(string str1, int num1)
        {
            return str1 + num1;
        }
    }
}
