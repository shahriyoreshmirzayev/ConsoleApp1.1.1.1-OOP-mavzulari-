using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1._1._1._1.OOP.OOP_2_dars
{
    class Person
    {
        private decimal _balance;
        private int _idNumbers;
        private string _username;
        private string _password;
        private string _name;
        public decimal Balance
        {
            get { return _balance; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The balance cannot be negative.");
                }
                _balance = value;
            }
        }
        public int IdNumbers
        {
            get { return _idNumbers; }
            set { _idNumbers = value; }
        }
        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public void PersonInformation()
        {
            Console.WriteLine($"Person name is: {Name}, passwords: {Password}, username: @{Username}, " +
                $" IDNUmbers: {IdNumbers}, Balanceeee :: {Balance}");
        }
    }
}
