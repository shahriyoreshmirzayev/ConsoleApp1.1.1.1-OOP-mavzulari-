using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1._1._1._1.OOP.OOP_2_dars
{
    class StudentAccount
    {
        private int _idNumbers;
        private string _name;
        private decimal _balance;
        public int IdNumbers
        {
            get { return _idNumbers; }
            set { _idNumbers = value; }
        }
        public string Name
        { 
            get { return _name; } 
            set { _name = value; } 
        }
        public decimal Balance
        {
            get { return _balance; }
            set { _balance = value; }
        }
        public string StudentAccountInformation()
        {
            return $"Student Name: {Name}, Student IDNumbers: {IdNumbers}, Balance: {Balance} dollars";
        }
    }
}
