using System;
using System.Collections.Generic;
using hungryNinja;

namespace hungryNinja
{
    class Program
    {
        static void Main(string[] args)
        {
            Buffet allYouCanEat = new Buffet();
            // Console.WriteLine(allYouCanEat.Serve().Name);

            Ninja blackShadow = new Ninja();

            while(!blackShadow.IsFull)
            {
                blackShadow.Eat(allYouCanEat.Serve());
            }
            
        }
    }
}