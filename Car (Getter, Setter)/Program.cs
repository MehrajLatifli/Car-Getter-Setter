using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Car_ConsoleApp
{



    class Car
    {

        public Car(int id, bool volume, string model, string vendor, int year = 0, int month = 0, int day = 0)
        {
            Id = id;

            Volume = volume;

            Model = model;

            Vendor = vendor;

            Year = year;

            Month = month;

            Day = day;

        }


        public Car()
        {

        }

        public int Id { get; set; }
        public bool Volume { get; set; }
        public string Model { get; set; }
        public string Vendor { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }




        public void show()
        {
            Console.Write(" Avtomobilin ilini daxil edin: ");
            Year = int.Parse(Console.ReadLine());

            Console.Write(" Avtomobilin ayını daxil edin: ");
            Month = int.Parse(Console.ReadLine());

            Console.Write(" Avtomobilin gününü daxil edin: ");
            Day = int.Parse(Console.ReadLine());


            DateTime carbirth = new DateTime(Year, Month, Day);
            DateTime dateTime = DateTime.Now;
            TimeSpan caryear = dateTime - carbirth;

            Console.WriteLine();

            Console.WriteLine($" Id: { Id}");
            Console.WriteLine($" Model: { Model}");
            Console.WriteLine($" Vendor: { Vendor}");
            Console.WriteLine($" Volume: { Volume}");
            Console.WriteLine($" Produce year: { (int)caryear.TotalDays / 360 }");
        }


    }












    class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Console.Write(" Avtomobilin ID -sini daxil edin: ");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.Write(" Avtomobilin  modelini daxil edin: ");
            string model = Console.ReadLine();

            Console.WriteLine();

            Console.Write(" Avtomobilin  istehsalçısını daxil edin: ");
            string vendor = Console.ReadLine();

            Console.WriteLine();

            Console.Write(" Avtomobilin  səsizliyi varmı? (True və ya False): ");
            bool volume = bool.Parse(Console.ReadLine());

            Console.WriteLine();

            Car cars = new Car(id, volume, model, vendor);

            cars.show();

            Console.ReadKey();
        }
    }
}
