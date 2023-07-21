using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1._1._1._1.OOP.OOP_1_dars
{
    public class Student
    {
        public string Name;
        public string FullName;
        public int GroupNumber;
        public string[] Subjects;
        public void StudentInformation()
        {
            Console.WriteLine($"Name: {Name}, FullName: {FullName}, Groupnumbers: {GroupNumber}");
        }
        public void ReadSubjects()
        {
            Console.WriteLine("Reading or student subjects");
            foreach (var subject in Subjects)
            {
                Console.WriteLine(subject);
            }
        }
    }
}
