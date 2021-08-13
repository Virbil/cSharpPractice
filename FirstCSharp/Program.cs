using System;
using System.Collections.Generic;


namespace FirstCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Variable to interpolate
            string place = "Coding Dojo";
            //Interpolated string, note the $
            string message = $"Hello {place}";
            // Displaying final message
            Console.WriteLine(message);

            // Console.WriteLine("The value of \r\n pi is " + 3.14159);

            // Console.WriteLine("My name is {0}, I am " + 28 + " years old", "Tim");
            // Console.WriteLine($"My name is {0}, I am " + 28 + " years old", "Tim");


            int numRings = 5;
            string name = "Kobe";
            if (numRings >= 5 && name == "Kobe")
            {
                Console.WriteLine("You are welcome to join the party");
            }
            else if (numRings > 2)
            {
                Console.WriteLine($"Decent...but {numRings} rings aren't enough");
            }
            else
            {
                Console.WriteLine("Go win some more rings");
            }


            // int start = 1;
            // int end = 100;
            // // loop from start to end including end
            // for (int index = start; index <= end; index++)
            // {
            //     if (index == 3 || index == 5 )
            //     {
            //         if (index == 3)
            //         {
            //             Console.WriteLine("Fizz");
            //         }
            //         else
            //         {
            //             Console.WriteLine("FizzBuzz");
            //         }
            //     }
            //     else 
            //     {
            //         Console.WriteLine(index);
            //     }
            // }

            // int i = 1;
            // while (i < 256)
            // {
            //     Console.WriteLine(i);
            //     i = i + 1;
            // }

            // Random rand = new Random();
            // for(int val = 0; val < 10; val++)
            // {
            //     //Prints the next random value between 2 and 8
            //     Console.WriteLine(rand.Next(2,8));
            // }

            // string[] myCars = new string[] { "Mazda Miata", "Ford Model T", "Dodge Challenger", "Nissan 300zx"}; 
            // foreach (string car in myCars)
            // {
            //     // We no longer need the index, because variable 'car' already represents each indexed value
            //     Console.WriteLine($"I own a {car}");
            // }


            //Initializing an empty list of Motorcycle Manufacturers
            List<string> bikes = new List<string>();
            //Use the Add function in a similar fashion to push
            bikes.Add("Kawasaki");
            bikes.Add("Triumph");
            bikes.Add("BMW");
            bikes.Add("Moto Guzzi");
            bikes.Add("Harley Davidson");
            bikes.Add("Suzuki");
            //Accessing a generic list value is the same as you would an array
            Console.WriteLine(bikes[2]); //Prints "BMW"
            Console.WriteLine($"We currently know of {bikes.Count} motorcycle manufacturers.");
            Console.WriteLine("The current manufacturers we have seen are:");
            for (var idx = 0; idx < bikes.Count; idx++)
            {
                Console.WriteLine("-" + bikes[idx]);
            }
            // Insert a new item between a specific index
            bikes.Insert(2, "Yamaha");
            //Removal from Generic List
            //In this case we are removing all manufacturers located in Japan
            bikes.Remove("Suzuki");
            bikes.Remove("Yamaha");
            bikes.RemoveAt(0); //RemoveAt has no return value however
            //The updated list can then be iterated through using a foreach loop
            Console.WriteLine("List of Non-Japanese Manufacturers:");
            foreach (string manu in bikes)
            {
                Console.WriteLine("-" + manu);
            }

            Dictionary<string,string> profile = new Dictionary<string,string>();
            //Almost all the methods that exists with Lists are the same with Dictionaries
            profile.Add("Name", "Speros");
            profile.Add("Language", "PHP");
            profile.Add("Location", "Greece");
            Console.WriteLine("Instructor Profile");
            Console.WriteLine("Name - " + profile["Name"]);
            Console.WriteLine("From - " + profile["Location"]);
            Console.WriteLine("Favorite Language - " + profile["Language"]);
            foreach (var entry in profile)  // var takes the place of KeyValuePair<string,string>
            {
                Console.WriteLine(entry.Key + " - " + entry.Value);
            }


        }
    }
}
