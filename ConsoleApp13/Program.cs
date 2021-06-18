using System;
using System.Collections.Generic;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            var myCar = new Car()
            {
                Make = "Ford",
                Model = "focus",
                Year = 2021
            };

            var mazda = new Car()

            {
                Make = "Mazdza",
                Model = "CX-5",
                Year = 2056,
            };

            var chevy = new Car("Chevy", "impala", 2001);

            var carList = new List<Car>() { myCar, mazda, chevy, };
            
            foreach(var vehicle in carList)
            {
                Console.WriteLine($"{vehicle.Make} {vehicle.Model}{vehicle.Year}");
            }




        }
    }
}
