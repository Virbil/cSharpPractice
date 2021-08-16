using System;

namespace oopLearnings
{
    class Program
    {
        public class Vehicle
        {
            public int NumPassengers;
            //Notice the Constructor function doesn't need
            //a return type or the static keyword
            public Vehicle(int val)
            {
                NumPassengers = val;
            }
        }

        static void Main(string[] args)
        {
            //Adding a value to the object; then passes it to the constructor
            Vehicle myVehicle = new Vehicle(7);
            Console.WriteLine($"My vehicle is holding {myVehicle.NumPassengers} people");
        }
    }
}
