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
    }
}
