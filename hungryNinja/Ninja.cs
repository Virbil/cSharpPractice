using System;
using System.Collections.Generic;

namespace hungryNinja
{
    class Ninja
    {
        private int calorieIntake;
        public List<Food> FoodHistory;
        public Ninja()
        {
            calorieIntake = 0;
            FoodHistory = new List<Food>();
        }
        public bool IsFull
        {
            get { return calorieIntake > 4000; }
        }
        public bool Eat(Food meal)
        {
            if(!IsFull)
            {
                calorieIntake += meal.Calories;
                FoodHistory.Add(meal);
                Console.WriteLine($"Ninja digs in to some delicious {meal.Name}");
            }
            else
                Console.WriteLine("Ninja is too full to eat!");

            return IsFull;
        }
    }
    
}




// class Ninja
//     {
//         private int calorieIntake;
//         public List<Food> FoodHistory;
//          
//         // add a constructor that sets calorieIntake to 0 and creates a new, empty list of Food objects to FoodHistory
//         public Ninja(int calorieIntake = 0)
//         {
//             List<Food> FoodHistory = new List<Food>();
//         }
//          
//         // add a public "getter" property called "IsFull"
//         // public bool IsFull 
//         // {
//         //     if (int calorieIntake > 1200) 
//         //     {
//         //         get { return true };                 
//         //     }
//         //     else { get { return false }};
//         // }
//          
//         // build out the Eat method
//         public void Eat(Food item)
//         {
//         }