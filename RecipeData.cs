using System.Collections.Generic;
using static CustomCrops.CropData;

namespace CustomCrops
{
    public class RecipeData
    {
        public string ProductName { get; set; }
        public string ID { get; set; }
        public string ProductDescription { get; set; }
        public string Type { get; set; } = "food";
        public string Buffs { get; set; } = "0 0 0 0 0 0 0 0 0 0 0";
        public int BuffsDuration { get; set; } = 0;
        public string Ingredients { get; set; } = "this 5";
        public string Condition { get; set; } = "l 100";
        public string Something { get; set; } = "1 10";
        public int ProductSellPrice { get; set; } = 100;
        public int RecipePurchasePrice { get; set; } = 100;
        public int Edibility { get; set; } = 25;
        internal int mealId { get; set; }
        internal int cropProductID { get; set; }
        internal static List<RecipeData> allRecipes = new List<RecipeData>();

        public RecipeData()
        {

        }

        internal string GetMealObjectInformation()
        {
            return $"{ProductName}/{ProductSellPrice}/{Edibility}/Cooking -7/{ProductName}/{ProductDescription}/{Type}/{Buffs}/{BuffsDuration}";
        }

        internal string getRecipeInformation()
        {
            return Ingredients + "/" + Something + "/" + mealId + "/" + Condition + "/" + ProductName;
        }

internal static void parseIngredients()
{
foreach (RecipeData recipe in RecipeData.allRecipes)
{
    recipe.Ingredients = recipe.Ingredients.Replace("this", recipe.cropProductID.ToString());

    string[] ingredients = recipe.Ingredients.Split(' ');
    int n = 0;
    foreach(string part in ingredients)
    {
        if(!int.TryParse(part,out n) && savedIds.ContainsKey(part))
        {
            recipe.Ingredients = recipe.Ingredients.Replace(part, savedIds[part].Product.ToString());
        }
    }

}
}

}
}
