using System;
using System.Collections.Generic;

namespace hungryNinja
{
    class Buffet
    {
        public List<Food> Menu;
         
        //constructor
        public Buffet()
        {
            Menu = new List<Food>()
            {
                new Food("Ice Cream", 1000, false, true),
                new Food("Cheese Burger", 1000, false, false),
                new Food("Ramen", 350, true, false),
                new Food("Bin Bin Bop", 700, true, false),
                new Food("Butter Chicken", 1100, false, true),
                new Food("Pad Thai", 620, true, false),
                new Food("Enchiladas", 1700, true, false)
            };
        }
         
        public Food Serve()
        {
            Random rand = new Random();
            return Menu[rand.Next(Menu.Count)];
        }
    }
}