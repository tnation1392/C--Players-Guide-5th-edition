using System;

namespace Players_Handbook.NewFolder
{
    internal class Simulassoup
    {
        enum Type
        {
            Soup,
            Stew,
            Gumbo
        }

        enum MainIngredient
        {
            Chicken,
            Mushrooms,
            Carrots,
            Potatoes
        }

        enum Seasoning
        {
            Spicy,
            Salty,
            Sweet
        }

        public static void Run()
        {
            (Type type, MainIngredient mainIngredient, Seasoning seasoning) soupInfo =
            (
                Type.Soup,
                MainIngredient.Chicken,
                Seasoning.Spicy
            );

            Console.WriteLine(
                $"The soup is currently a {soupInfo.type} with {soupInfo.mainIngredient} and is {soupInfo.seasoning}."
            );

            Console.WriteLine("What would you like the soup to be? (Soup, Stew, Gumbo)?");
            string type = Console.ReadLine();

            Console.WriteLine("What would you like the main ingredient to be? (Mushroom, Chicken, Carrots, Potatoes)?");
            string mainIngredient = Console.ReadLine();

            Console.WriteLine("What would you like the seasoning to be? (Spicy, Salty, Sweet)?");
            string seasoning = Console.ReadLine();

            Console.WriteLine($"The soup is a {type} with {mainIngredient} and is {seasoning}.");
        }
    }
}