using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1._1._1._1.OOP.OOP_1_dars
{
    class Car
    {
        public string Name;
        public string Brand;
        public string Color;
        public int Speed;
        public Car(string name, string brand, string color, int speed)
        {
            Name = name;
            Brand = brand;
            Color = color;
            Speed = speed;
            Console.WriteLine("Car konstruktori hisoblanadi.");
        }

        public void GetSpeed()
        {
            Console.WriteLine($"{Name}: , {Speed}, {Color}, {Speed}");
        }
    }
}
