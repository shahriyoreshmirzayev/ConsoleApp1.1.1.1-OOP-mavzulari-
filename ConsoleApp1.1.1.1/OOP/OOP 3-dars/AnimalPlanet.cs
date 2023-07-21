using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1._1._1._1.OOP.OOP_3_dars
{
    class AnimalPlanet
    {
        public string Rangi { get; set; }
        public int Oyoqlari { get; set; }
    }
    class Pet : AnimalPlanet
    {
        public void Uy_Hayvoni()
        {
            Console.WriteLine("Uy hayvonlari uyda uy egalarining asablarini tamom qilish bo'yicha " +
                "chempion hisoblanadi mo'o'rab baaarab");
        }
    }
    class Bird : AnimalPlanet
    {
        public void Qush()
        {
            Console.WriteLine("Qushlar samoda parvoz qila oladilar");
        }
    }
    class Cat : AnimalPlanet
    {
        public void Mushuk()
        {
            Console.WriteLine("Mushuklar miyovlab odamga huzur bag'ishlaydilar");
        }
    }
    class Dogg : AnimalPlanet
    {
        public void Kuchuk()
        {
            Console.WriteLine("Kuchuklar uylarni qo'riq;ash bo'yicha eng yaxshi yordamchi hisoblanishadi");
        }
    }
    class Cow : AnimalPlanet
    {
        public void Sigir()
        {
            Console.WriteLine("Sigirlar uy egalariga sut va go'sht berish bo'yicha chempion hisoblanishadi");
            Console.WriteLine("Hozirgi kunda ayrim bollarning sigirdan farqi yo'q hisoblanadi");
        }
    }
    class Straus : AnimalPlanet
    {
        public void Men()
        {
            Console.WriteLine("Bu qush yoki hayvonligi haqida ma'lumotim yo'q");
            Console.WriteLine("Google dan ham qaragim kelmadi");
        }
    }
    class Bat : AnimalPlanet
    {
        public void BatMan()
        {
            Console.WriteLine("Batman kinosi dunyoda eng mashxur va ommabop kinolardan biri sanaladi");
        }
    }
    class Eagle : AnimalPlanet
    {
        public void B14()
        {
            Console.WriteLine("Bu eagle deganlari CS 1.6 da eng mashxur va kuchli to'pponchadir");
        }
    }
}
