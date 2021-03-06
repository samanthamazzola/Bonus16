using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Bonus16
{
    public class Car
    {

        // Fields
        private string make;
        private string model;
        private int year;
        private double price;


        // Properties
        public string Make
        {
            set { make = value; }
            get { return make; }
        }

        public string Model
        {
            set { model = value; }
            get { return model; }
        }

        public int Year
        {
            set { year = value; }
            get { return year; }
        }

        public double Price
        {
            set { price = value; }
            get { return price; }
        }

        public double Mileage { get; internal set; }


        // default constructor (takes no param)
        public Car()
        {
            Make = "Make";
            Model = "Model";
            Year = 0000;
            Price = 00000;
        }

        // overload constructor 
        public Car(string ma, string mo, int yr, int p)
        {
            Make = ma;
            Model = mo;
            Year = yr;
            Price = p;
        }

        // method from main class
        // virtual method

        public virtual void PrintInfo()
        {
            Console.WriteLine($"{Make,-15} {Model,-15} {Year,-15} {Price,-15}");
        }

        public void RemoveAt()
        {
            
        }

        //public void List<Car>InsertAt(int index, Car item)
        //{
        //    (int.Parse(input) + 1);
        //}
    }
}
