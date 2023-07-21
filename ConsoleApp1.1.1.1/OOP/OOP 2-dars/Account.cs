using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1._1._1._1.OOP.OOP_2_dars
{
    class Account
    {
        private string _owner;
        private string _password = "1212";
        private double _money;
        public string Owner
        {
            get
            {
                return _owner;
            }
            set
            {
                _owner = value;
            }
        }
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                if(value == _password)
                {
                _password = value;
                }
                else
                {
                    Console.WriteLine("Parol noto'g'ri");
                }
            }
        }
        public double Money
        {
            get
            {
                return _money;
            }
            set
            {
                _money = value;
            }
        }
        public Account(string name, string password, double money = 0)
        {
            Owner = name;
            Password = password;
            Money = money;
        }
    }
}

