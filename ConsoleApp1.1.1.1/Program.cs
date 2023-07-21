using ConsoleApp1._1._1._1.OOP.OOP_1_dars;
using ConsoleApp1._1._1._1.OOP.OOP_2_dars;
using ConsoleApp1._1._1._1.OOP.OOP_3_dars;
using ConsoleApp1._1._1._1.OOP.OOP_4_dars.Polymorphism_Homework;
using ConsoleApp1._1._1._1.OOP.OOP_4_dars.Sinov_Polymorphism;
using System.Formats.Asn1;

namespace ConsoleApp1._1._1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = Calculator.Add(2, 3);
            Console.WriteLine(sum);

            Console.WriteLine("hello");

            //AddAttributes addAttributes = new AddAttributes();
            //int sum = addAttributes.Qoshish(6, 7);
            //double sum1 = addAttributes.Qoshish1(6, 7.1);
            //double sum2 = addAttributes.Qoshish3(1, 2, 3);
            //string sum3 = addAttributes.Qoshish4("Salom", " oka");
            //string sum4 = addAttributes.Qoshish5("pashol", 12);
            //Console.WriteLine("Yig'indi: " + sum);
            //Console.WriteLine("Yig'indi: " + sum1);
            //Console.WriteLine("Yig'indi: " + sum2);
            //Console.WriteLine("Yig'inid: " + sum3);
            //Console.WriteLine("Yig'inid: " + sum4);








            //TelegramRules telegramRules = new TelegramRules();
            //telegramRules.Rules();
            //MathRules mathRules = new MathRules();
            //mathRules.Rules();

            //ProggrammingGroup proggrammingGroup = new ProggrammingGroup();
            //proggrammingGroup.Rules();

            //StaticClass staticClass = new StaticClass();
            //staticClass.Name = "Shahriyor";
            //staticClass.Age = 23;
            //staticClass.Nationality = "Uzbek";
            //staticClass.PasportCode = "AC";
            //Console.WriteLine(staticClass.ToString());
            //Console.WriteLine(staticClass.Name);
            //Console.WriteLine(staticClass.Age);
            //Console.WriteLine(staticClass.Nationality);
            //Console.WriteLine(staticClass.PasportCode);

            //Console.WriteLine(staticClass.ToString());





            /*AnimalPlanet animalPlanet = new AnimalPlanet();
            Pet pet = new Pet();
            Bird bird = new Bird();
            Cat cat = new Cat();
            Dogg dogg = new Dogg();
            Cow cow = new Cow();
            Straus straus = new Straus();
            Bat bat = new Bat();
            Eagle eagle = new Eagle();

            Book book = new Book();
            EBook eBook = new EBook();
            PaperBooks paperBooks = new PaperBooks();
            //eBook.Autors = "Eshqulov Javlon";
            eBook.Price = 10000;
            //eBook.Chegirma = 1000;
            //eBook.Sarlavha = "Elektron";
            //eBook.Sahifalar_soni = 1012;

            //eBook.Sayt_nomi = "Ziyonet.com";
            //eBook.Hajmi = 12;
            //eBook.Chop_etish();


            //paperBooks.Autors = "Javlon Eshqulov";
            paperBooks.Price = 20000;
            //paperBooks.Chegirma = 2000;
            //paperBooks.Sarlavha = "Qattiq";
            //paperBooks.Sahifalar_soni = 1212;

            //paperBooks.Vazni = 1;
            //paperBooks.Yetkazib_berish = 3;

            //Console.WriteLine("Book");
            //Console.WriteLine(eBook.Autors + "\n" + eBook.Price + "\n" + eBook.Chegirma + "\n" + 
            //eBook.Sarlavha + "\n" + eBook.Sahifalar_soni + "\n" + eBook.Sayt_nomi + "\n" + eBook.Hajmi);
            //eBook.Chop_etish();

            Console.WriteLine("EBooks Sotuv narxi va Chegirma narxi");
            eBook.Sotuv_narxi();
            eBook.Chegirma_narxi();
            Console.WriteLine(eBook.Price);


            Console.WriteLine("\n==============================\n");

            // Console.WriteLine("PaperBooks");
            //Console.WriteLine(paperBooks.Autors + "\n" + paperBooks.Price + "\n" + paperBooks.Chegirma + 
            //paperBooks.Sarlavha + "\n" + paperBooks.Sahifalar_soni + "\n" + paperBooks.Vazni + "\n" + 
            //paperBooks.Yetkazib_berish);
            Console.WriteLine("PaperBooks Sotuv narxi va Chegirma narxi");
            paperBooks.Sotuv_narxi();
            paperBooks.Chegirma_narxi();
            Console.WriteLine(paperBooks.Price);

            //Dog dog = new Dog();
            //dog.Type = "Alabay";
            //dog.Legs = 4;
            //dog.Color = "Black";
            //Console.WriteLine(dog.Type + " " + dog.Color);*/
        }
        public static void oop1oop2()
        {
            /*//Person person = new Person();
           //person.Balance = 100;
           //person.IdNumbers = 1;
           //person.Username = "username";
           //person.Password = "password";
           //person.Name = "name";
           //person.PersonInformation();

           //Book book = new Book();
           //book.BookName = "Mexrobdan Chayon";
           //book.Price = 100;
           //book.Autors = new string[] { "Tohir Malik", "O'tkir Hoshimov" };
           //book.PrintBookInformation();

           //Employee employee = new Employee();
           //employee.Name = "Test";
           //employee.IDNumbers = 1;
           //employee.Money = 100;
           //Console.WriteLine(employee.EmployeePrint());
           //employee.EmployeePrintText();

           //StudentAccount studentAccount = new StudentAccount();
           //studentAccount.Name = "Shahzod";
           //studentAccount.IdNumbers = 6531;
           //studentAccount.Balance = 10000;
           //Console.WriteLine(studentAccount.StudentAccountInformation());

           //Time time = new Time();
           //time.Hours = 1;
           //time.Minutes = 12;
           //time.Seconds = 123;
           //string getformatted = time.GetOfTheTime();
           //Console.WriteLine(getformatted);

           //Console.Write("Hafta kunini kiriting: ");
           //int DayIndex = int.Parse(Console.ReadLine());
           //Date date = new Date();
           //date.DayOfWeek = DayIndex;
           //Console.WriteLine($"{date.DayOfWeek}  {date.GetTextOfDay()}");

           //Account account1 = new Account("Shahriyor", "1212");
           // account1.Password = "5655";
           // Console.WriteLine(account1.Password);

           //Student student = new Student();
           //student.Name = "Jakhongir";
           //student.FullName = "Khudoynazaroff";
           //student.GroupNumber = 2001;
           //student.Subjects = new string[] { "Math", "Physics", "Mother Language", "History", "Biology" };
           //student.StudentInformation();
           //student.ReadSubjects();

           //MyDate myDate = new MyDate();
           // myDate.year = 2023;
           // myDate.month = 07;
           // myDate.day = 15;
           // myDate.DateFormate();

           //Car car = new Car("Cobalt", "Chevrolet", "White", 200);
           // /*car.Name = "Cobalt";
           // car.Brand = "Chevrolet";
           // car.Color = "White";
           // car.Speed = 150;*/
            // Console.WriteLine("OOP 1-dars");*/
        }
    }
}