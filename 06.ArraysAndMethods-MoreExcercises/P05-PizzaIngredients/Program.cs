using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {
            var ingredients = Console.ReadLine().Split().ToArray();
            int maxIngredientLength = int.Parse(Console.ReadLine());
            int ingredientCount = 0;
            var addedIngredients = new List<string>();
            for (int i = 0; i < ingredients.Length && ingredientCount < 10; i++)
            {
                if (ingredients[i].Length == maxIngredientLength)
                {
                    addedIngredients.Add(ingredients[i]);
                    Console.WriteLine("Adding {0}.", ingredients[i]);
                    ingredientCount++;
                }
            }
            Console.WriteLine($"Made pizza with total of {ingredientCount} ingredients.");
            Console.WriteLine($"The ingredients are: {string.Join(", ", addedIngredients)}.");
        }
    }
}
