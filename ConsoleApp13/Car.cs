using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp13
{
    public class Car
    {
           public Car()
           {

           }
        public Car(string make, string model, int year)
        {
            Make = Make;
            Model = Model;
            Year = Year;
        }
       

        
       
        
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        

        
    }
}
