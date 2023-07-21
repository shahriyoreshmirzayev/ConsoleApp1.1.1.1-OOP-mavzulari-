using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1._1._1._1.OOP.OOP_2_dars
{
    class Employee
    {
        private int _idNumbers;
        private string _name;
        private decimal _money;
        public int IDNumbers
        {
            get { return _idNumbers; }
            set { _idNumbers = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public decimal Money
        {
            get { return _money; }
            set { _money = value; }
        }
        public string EmployeePrint()
        {
            return $"IDNumbers: {IDNumbers}, Name: {Name}, Money: {Money} dollars";
        }
        public void EmployeePrintText()
        {
            Console.WriteLine("Fucking ugly bitch");
        }
    }
}
