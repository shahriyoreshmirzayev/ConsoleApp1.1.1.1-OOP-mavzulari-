using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1._1._1._1.OOP.OOP_3_dars
{
    class EBook : Book
    {
        public string Sayt_nomi { get; set; }
        public int Hajmi { get; set; }
        public void Chop_etish()
        {
            Console.WriteLine("Sarlovhani chop etish");
        }
    }
}
