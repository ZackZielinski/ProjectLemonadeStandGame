using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Recipe
    {
        int lemonsneeded = 5;
        int sugarneeded = 3;
        int iceneeded = 3;
        public int LemonsNeeded { get { return lemonsneeded; } }
        public int SugarNeeded { get { return sugarneeded; } }
        public int IceNeeded { get { return iceneeded; } }

        List<int> RecipeList;
        public Recipe()
        {
            RecipeList = new List<int>();
        }
        public void DisplayRecipe()
        {
            RecipeList.Add(LemonsNeeded);
            RecipeList.Add(SugarNeeded);
            RecipeList.Add(IceNeeded);
            Console.WriteLine("\nNow you need to make the lemonade.");
            Console.WriteLine($"The recipe for lemonade requires {RecipeList[0]} Lemons, {RecipeList[1]} units of Sugar & {RecipeList[2]} Ice cubes to keep it cold.");
        }

    }
}
