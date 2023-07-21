using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1._1._1._1.OOP.OOP_4_dars.Sinov_Polymorphism
{
    class StaticClass
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Nationality { get; set; }
        public string PasportCode { get; set; }
        public override string ToString()
        {
            return $"Ismi: {Name}\nYoshi: {Age}\nMillati: {Nationality}\nPassport Seriyasi: {PasportCode}";
        }
    }
}
