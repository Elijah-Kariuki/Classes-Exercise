using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Car
    {
        public Car()
        {
        }
        public Car(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
        }

        //Fields
        //Properties
        //Methods

        //Create a Make property of type string that is public
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
    }
}
