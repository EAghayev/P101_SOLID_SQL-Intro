using System;

namespace Liskov
{
    class Program
    {
        static void Main(string[] args)
        {
            BMW bmw = new BMW();
            Mercedes mercedes = new Mercedes();

            Console.WriteLine(bmw.Start());
            Console.WriteLine(bmw.StartAirConditioner());

            Console.WriteLine(mercedes.Start());
            Console.WriteLine(mercedes.StartAirConditioner());

            Car car = new Qaz31();

            Console.WriteLine(car.Start());
            //Console.WriteLine(car.StartAirconditioner());
        }
    }
}
