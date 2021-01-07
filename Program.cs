using System;

namespace ISP
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            Airplane plane = new Airplane();
            Console.WriteLine();
            car.Drive();
            plane.Fly();
            


            Console.ReadLine();
        }
    }
}
