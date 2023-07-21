using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1._1._1._1.OOP.OOP_1_dars
{
    public class MyDate
    {
        public int year;
        public int month;
        public int day;
        public void DateFormate()
        {
            Console.WriteLine($"Bugungi sana: {day}.{month}.{year}");
        }
    }
}
