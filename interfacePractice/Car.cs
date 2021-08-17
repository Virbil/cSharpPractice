// "implementing" an interface on a class looks much like "inheriting" from another
using System;

class Car : Vehicle, IRideable
{
    // We can add members that are unique to Cars, things that won't describe ALL vehicles
    public string Make;
    public string Model;
    // but when we define a constructor for Car, we need to satisfy any constructor requirements
    // for at least ONE constructor on the parent Vehicle class
    public Car(string color, string make, string model) : base(color)
    {
        Make = make;
        Model = model;
    }

    // we can use DistanceTraveled to be a wrapper for "Odometer"
    public double DistanceTraveled
    {
        get { return Odometer; }
        set { Odometer = value; }
    }
    public void Ride(double distance)
    {
        // here we can choose implement this method however we wish
        // as long as we meet the requirements of the method
        Console.WriteLine($"... driving your {Make} {Model}...");
        DistanceTraveled += distance;
    }

    public override void MakeNoise()
    {
        Console.WriteLine("Beep beep!");
    }
}