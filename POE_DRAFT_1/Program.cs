using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POE_DRAFT_1
{
    class Program
    {
        static void main(string [] args)
        {

        }
       
        public class Ingredient
        {
            // Declarations
            public string Name;
            public double Quantity;
            public string Unit;

            // Constructor for initializing ingredient
            public Ingredient(string name, double quantity, string unit)
            {
                Name = name;
                Quantity = quantity;
                Unit = unit;
            }
        }

        public class Recipe
        {
            // Array to store ingredients entered.
            private Ingredient[] ingredients;
            private string[] steps;

            //Constuctor to initialize a recipe object with given ingredients.
            public Recipe(int ingredientCount, int stepCount)
            {
                ingredients = new Ingredient[ingredientCount];
                steps = new string[stepCount];
            }

            // Method to add an ingredient to the recipe
            public void AddIngredient(int index, Ingredient ingredient)
            {
                if (index >= 0 && index < ingredients.Length)
                {
                    ingredients[index] = ingredient;
                }
                else
                {
                    Console.WriteLine("Invalid Input for adding ingredient");
                }
            }

            // Method to add steps to the recipe
            public void AddStep(int index, string step)
            {
                if (index >= 0 && index < steps.Length)
                {
                    steps[index] = step;
                }
                else
                {
                    Console.WriteLine("Invalid Input for adding a step");
                }
            }

            // Method to display recipe
            public void DisplayRecipe()
            {
                Console.Write("Recipe: ");
                Console.Write("Ingredients: ");
                foreach (var ingredient in ingredients)
                {
                    Console.WriteLine($"{ingredient.Quantity}{ingredient.Unit} of {ingredient.Name}");
                }
            }
        }
    }
}
