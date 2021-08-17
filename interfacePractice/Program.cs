using System;
using System.Collections.Generic;

namespace interfacePractice
{
    class Program
    {
        static void Main(string[] args)
        {
                IRideable[] variousRideables = new IRideable[]
            {
                new Car("Yellow", "Dodge", "Dart"),
                new Car("Green", "Ford", "Fiesta"),
                new Horse("Silver Queen", 100),
                new Horse("Samammish", 75),
            };
            // let them all ride!
            foreach(var rideable in variousRideables)
            {
                // each "rideable" object will be able to invoke the common "Ride()" method
                // however the implementation of "Ride()" will be unique to how each class has chosen to build it
                rideable.Ride(50);
            }
            Horse wilbur = new Horse("Wilbur", 120);
            Car volvo = new Car("Yellow", "Volvo", "240");
            
            // sally starts out with a horse
            Person sally = new Person("Sally", wilbur);
            // sally can ride her horse
            sally.GoSomewhere(34);
            
            // we can also change her Transport to a Car
            sally.Transport = volvo;
            sally.GoSomewhere(100);
            sally.GetInfo();


            // IEnumerable practice
            // Let's make a string array
            string[] wordArray = new string[]
            {
                "Goat", "Bear", "Skunk", "Deer"
            };
            // And a List of strings
            List<string> wordList = new List<string>()
            {
                "Plate", "Cup", "Fork", "Meat Cleaver", "Spatula"
            };
            // We can call our function with either!
            LoopingSomeWords(wordArray);
            LoopingSomeWords(wordList);
        }

        static void LoopingSomeWords(IEnumerable<string> someWords)
        {
            foreach(var word in someWords)
            {
                Console.WriteLine(word);
            }
        }
    }
}
