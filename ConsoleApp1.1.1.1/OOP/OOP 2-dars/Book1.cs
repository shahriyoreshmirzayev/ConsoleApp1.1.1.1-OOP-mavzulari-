using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1._1._1._1.OOP.OOP_2_dars
{
    class Book1
    {
        private string _bookName;
        private string[] _autors;
        private int _price;
        private decimal _isbn;
        public string BookName
        {
            get { return _bookName; }
            set { _bookName = value; }
        }
        public string[] Autors
        {
            get { return _autors; }
            set { _autors = value; }
        }
        public int Price
        {
            get { return _price; }
            set { _price = value; }
        }
        public decimal Isbn
        {
            get { return _isbn; }
            set { _isbn = value; }
        }
        public void PrintBookInformation()
        {
            Console.WriteLine($"Book: {BookName}");
            Console.WriteLine("Autors: ");
            foreach ( var item in _autors )
            {
                Console.WriteLine(item);
            }
        }
    }
}
