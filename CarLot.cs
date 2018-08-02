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

        //method
        public void RemoveAt(int input) //method to remove car.... calling in the main
        {
            Lot.RemoveAt(input); //removes at specific index input 
        }
        public void Insert(int input) 
        {
            Lot.Insert(input); //insert at specific spot
        }
    }
}


//List<T> someList = new List();
//someList.Add(x)        // Adds x to the end of the list
//someList.Insert(0, x)  // Adds x at the given index
 //someList.Remove(x)     // Removes the first x observed
 //someList.RemoveAt(0)   // Removes the item at the given index
 //someList.Count()       // Always good to know how many elements you have!