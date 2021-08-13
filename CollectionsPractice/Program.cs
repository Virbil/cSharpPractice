using System;
using System.Collections.Generic;

namespace CollectionsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercises:
            //  //   Three Basic Arrays
            //     Create an array to hold integer values 0 through 9
            // int[] numArray = new int[10];
            // for (int index = 0; index  < numArray.Length; index++)
            // {
            //     numArray[index] = index;
            // }
            // foreach (int index in numArray)
            // {
            //     Console.WriteLine(index);
            // }

            //  //   Create an array of the names "Tim", "Martin", "Nikki", & "Sara"
            string[] nameArray = new string[4];
            nameArray[0] = "Tim";
            nameArray[1] = "Martin";
            nameArray[2] = "Nikki";
            nameArray[3] = "Sara";
            // foreach (string name in nameArray)
            // {
            //     System.Console.WriteLine(name);
            // }

            //  //   Create an array of length 10 that alternates between true and false values, starting with true
            // bool[] tAndF = new bool[10];
            // for(int index = 0; index < tAndF.Length; index++)
            // {
            //     if (index%2 == 0) 
            //     {
            //         tAndF[index] = true;
            //     }
            //     else
            //     {
            //         tAndF[index] = false;
            //     }
            // }
            // foreach (bool result in tAndF)
            // {
            //     System.Console.WriteLine(result);
            // }

            //  //   List of Flavors
            //  //   Create a list of ice cream flavors that holds at least 5 different flavors (feel free to add more than 5!)
                List<string> flavors = new List<string>();
                flavors.Add("Mint Chocolate Chip");
                flavors.Add("Chocolate");
                flavors.Add("Vanilla");
                flavors.Add("Cookies 'n Cream");
                flavors.Add("Butter Pecan");
            // //     Output the length of this list after building it
            // System.Console.WriteLine(flavors.Count);
            // //     Output the third flavor in the list, then remove this value
            // string vanilla = flavors[2];
            // System.Console.WriteLine(vanilla);
            // flavors.Remove(vanilla);
            // //     Output the new length of the list (It should just be one fewer!)
            // System.Console.WriteLine(flavors.Count);


            //     User Info Dictionary
            //     Create a dictionary that will store both string keys as well as string values
            //     Add key/value pairs to this dictionary where:
            //     each key is a name from your names array
            //     each value is a randomly select a flavor from your flavors list.

            Random rand = new Random();
            Dictionary<string,string> profile = new Dictionary<string,string>();
            foreach (string name in nameArray)
            {
                // Console.WriteLine($"My name is {name} and my favorite ice cream is {flavors[rand.Next(0, flavors.Count)]} ");
                profile.Add(name, flavors[rand.Next(0, flavors.Count)]);

            }
            //     Loop through the dictionary and print out each user's name and their associated ice cream flavor
            foreach (var entry in profile)
            {
                Console.WriteLine(entry.Key + " - " + entry.Value);
            }
        }
    }
}
