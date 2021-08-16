using System;

namespace humanClass
{
    class Human
{
    // Fields for Human
    public string Name;
    public int Strength;
    public int Intelligence;
    public int Dexterity;
    private int health;
     
    // add a public "getter" property to access healthcopy
    public int healthcopy
    {
        get { return health; }
    }
     
    // Add a constructor that takes a value to set Name, and set the remaining fields to default values
    public Human(string name)
    {
        Name = name;
        Strength = 3;
        Intelligence = 3;
        Dexterity = 3;
        health = 100;
    }
     
    // Add a constructor to assign custom values to all fields
    public Human(string custName, int custStr, int custIntel, int custDex, int custHealth)
    {
        Name = custName;
        Strength = custStr;
        Intelligence = custIntel;
        Dexterity = custDex;
        health = custHealth;
    }
     
    // Build Attack method
    // reduce the health of a Human object that is passed as a parameter. 
    // The damage done should be 5 * strength (5 points of damage to the attacked, 
    // for each 1 point of strength of the attacker). This method should return 
    // the remaining health of the target object.
    public int Attack(Human target)
    {
        return target.health -= 5;
    }
}
    class Program
    {
        static void Main(string[] args)
        {
            Human itsMe = new Human("Bryce");
            string myName = itsMe.Name;
            Console.WriteLine(myName);

            itsMe.Attack(itsMe);
            itsMe.Attack(itsMe);
            itsMe.Attack(itsMe);
            System.Console.WriteLine(itsMe.healthcopy);

            Human itsStef = new Human("Stef", 100, 1000, 45, 200);
            System.Console.WriteLine(itsStef.Name);
        }
    }
}
