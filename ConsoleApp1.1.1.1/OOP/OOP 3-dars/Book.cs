using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1._1._1._1.OOP.OOP_3_dars
{
    class Book
    {
        public string Autors { get; set; }
        public int Price { get; set; }
        public int Chegirma { get; set; }
        public string Sarlavha { get; set; }
        public int Sahifalar_soni { get; set; }
        public void Sotuv_narxi()
        {
            Console.WriteLine(Price);
        }
        public void Chegirma_narxi()
        {
            Console.WriteLine(Price * 1.3);
        }
    }
}
