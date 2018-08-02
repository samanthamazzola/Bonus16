using System;
using System.Collections.Generic;
using System.Linq;

namespace Bonus16
{
    public class CarLot
    {
        private List<Car> lot; //private create list of Car class 

        //properties
        public List<Car> Lot //taking in Car class list and passing Lot list
        {
            set;
            get;
        }
        //constructor
        public CarLot()
        {
            Lot = new List<Car>();
        }
        public CarLot(List<Car> cars) //taking the Car list 
        {
            Lot = cars;
        }
    }
}
