using System;

namespace P07_CakeIngredients
{
    class Program
    {
        static void Main(string[] args)
        {
            string ingredient = Console.ReadLine();
            int ingredientCounter = 0;

            while (ingredient != "Bake!")
            {
                Console.WriteLine($"Adding ingredient {ingredient}.");
                ingredientCounter++;
                ingredient = Console.ReadLine();
            }
            Console.WriteLine($"Preparing cake with {ingredientCounter} ingredients.");
        }
    }
}
