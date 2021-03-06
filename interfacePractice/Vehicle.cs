abstract class Vehicle
{
    public int NumPassengers;
    public string Color;
    public double Odometer;

    public abstract void MakeNoise();
    // Say Vechicle has two overloaded constructors
    // We will either need to pass up two values (int, string), from Car ...
    public Vehicle(int numPas, string col)
    {   
        NumPassengers = numPas;
        Color = col;
        Odometer = 0;
    }
    // Or just one string value.  
    public Vehicle(string col)
    {
        NumPassengers = 5;
        Color = col;
        Odometer = 0;
    }
}
