using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1._1._1._1.OOP.OOP_4_dars.Sinov_Polymorphism
{
    class TelegramRules
    {
        public virtual void Rules()
        {
            Console.WriteLine("Guruh qoidalari !");
            Console.WriteLine("1.So'kinish mumkin emas");
            Console.WriteLine("2.18+ video tashlash mumkin emas");
        }
    }
    class MathRules : TelegramRules
    {
        public override void Rules()
        {
            Console.WriteLine("=====Matematika guruhi qoidalari======");
            base.Rules();
            Console.WriteLine("3.Har kuni bitta masala va misol ishlab kleish shart");
        }
    }
    class  ProggrammingGroup : TelegramRules 
    {
        public override void Rules()
        {
            Console.WriteLine("Dasturlash guruhi qoidalari");
            base.Rules();
            Console.WriteLine("3.Dasturlashga oid bo'lmagan suhbatlarda gaplashish ta'qiqlanadi");
        }
    }
}
