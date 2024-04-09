using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POE_DRAFT_1
{
    class Program
    {
        // Main Program run the classes.
        static void main(string [] args)
        {
            // Initialize varibles
            int ingredientCount;
            int stepCount;
            Recipe recipe;

            // Prompts to get ingredient and step numbers
            Console.WriteLine("Enter number of Ingredients: ");
            while (!int.TryParse(Console.ReadLine(), out ingredientCount) || ingredientCount <= 0)
            {
                Console.WriteLine("Please enter valid number of ingredients: ");
            }

            Console.WriteLine("Enter number of steps: ");
            while (!int.TryParse(Console.ReadLine(), out stepCount) || stepCount <= 0)
            {
                Console.WriteLine("Please enter valid number of steps: ");
            }

            // A new Recipe object
            recipe = new Recipe(ingredientCount, stepCount);

            // Prompts to enter ingredients
            for(int i = 0; i < ingredientCount; i++)
            {
                Console.WriteLine($"Enter name of ingredient: {i + 1}: ");
                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.WriteLine($"Enter name of Quantity: {i + 1}: ");
                double quantity;
                while(!double.TryParse(Console.ReadLine(), out quantity) || quantity <= 0)
                {
                    Console.WriteLine("Please a valid number: ");
                }

                Console.Write("Unit: ");
                string unit = Console.ReadLine();

                // Ingredient object to add to recipe
                recipe.AddIngredient(i, new Ingredient(name, quantity, unit));
            }

            // Prompts to enter steps
            for(int i = 0; i < stepCount; i++)
            {
                Console.WriteLine($"Enter step {i + 1}:");
                string step = Console.ReadLine();
                recipe.AddStep(i, step);
            }

            // Recipe display
            recipe.DisplayRecipe();

            // Scaling the recipe
            Console.WriteLine("Enter scaling factor (0.5 for half, 2 for double, 3 for triple:");
            double factor;
            while(!double.TryParse(Console.ReadLine(), out factor) || (factor != 0.5 && factor != 2 && factor !=3))
            {
                Console.WriteLine("Please  enter a valid factor: ");
            }

            // Reset quantities
            recipe.ScaleRecipe(factor);
            recipe.DisplayRecipe();

            // Clear recipe
            recipe.ClearRecipe();
            Console.WriteLine("Recipe cleared.");

            Console.ReadLine();

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
                Console.WriteLine("Steps: ");
                for (int i = 0; i < steps.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {steps[i]}");
                }
            }

            // Method to scale the recipe by factor
            public void ScaleRecipe(double factor)
            {
                foreach (var ingredient in ingredients)
                {
                    ingredient.Quantity *= factor;
                }
            }

            // Method to Reset the ingredient Quanties to original values
            public void ResetQuantities()
            {

            }

            // Method to clear the recipe data entered.
            public void ClearRecipe()
            {
                ingredients = new Ingredient[ingredients.Length];
                steps = new string[steps.Length];
            }
        }
    }
}
