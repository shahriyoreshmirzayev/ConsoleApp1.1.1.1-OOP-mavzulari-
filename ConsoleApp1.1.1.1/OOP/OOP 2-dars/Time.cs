using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1._1._1._1.OOP.OOP_2_dars
{
    internal class Time
    {
        private int _hours;
        private int _minutes;
        private int _seconds;
        public int Hours
        {
            get { return _hours; }
            set { _hours = value; }
        }
        public int Minutes
        {
            get { return _minutes; }
            set { _minutes = value; }
        }
        public int Seconds
        {
            get { return _seconds; }
            set { _seconds = value; }
        }
        public string GetOfTheTime()
        {
            return $"{_hours}.{_minutes}.{_seconds}";
        }
    }
}
