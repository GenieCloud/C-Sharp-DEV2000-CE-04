using System;
using System.Collections.Generic;

namespace Jones_James_CE04
{
    class Program
    {
        static void Main(string[] args)
        {
            /* James M. Jones
             * 03/19/2021
             * DEV2000-O 02: Introduction to Development II
             * 2.2 Code Exercise 04: Dictionaries
             */

            //Problem #1: Movie Information

            Console.WriteLine("Hello and welcome to Movie Times!");

            Console.WriteLine("\r\nHere is a list of movie titles and their running times.\r\n");

            //First I want to create a dictionary.
            //With string and integer dataTypes.
            Dictionary<string, int> moviesWithRuntimes = new Dictionary<string, int>()
            {   //Each element must have a key and value pair.
                {"Ghostbusters", 107 },
                {"Clue", 97 },
                {"Antman", 118 },
                {"Moulin Rouge", 130 }
            };

            //Next, I want to create a forEach loop to cycle through the
            // dictionary and display the movie titles and runtimes.
            foreach (KeyValuePair<string, int> movie in moviesWithRuntimes)
            {
                Console.WriteLine("{0} has a running time of {1} minutes.",movie.Key, movie.Value);
            }

            //Problem #2: Recipe Cookbook

            Console.WriteLine("\r\nWelcome to the Recipe Lookup Program!\r\n");

            Console.WriteLine("I will ask you for (3) names of recipes in the cookbook and a page number that each one is on.\r\n");

            Console.WriteLine("After that I can tell you what page number any recipe is on.");

            //First, I want to create a dictionary that will hold the names of
            //the user's favorite recipes and the page numbers of the recipes.
            Dictionary<string, int> favoriteRecipes = new Dictionary<string, int>()
            {

            };

            for (int i = 0; favoriteRecipes.Count < 3; i++ )
            {
                //We want to ask for the name of each recipe.
                Console.WriteLine("Please type in the name of recipe #{0} ?", i + 1);

                //listen for the user's response.
                string recipeName = Console.ReadLine();

                while (string.IsNullOrWhiteSpace(recipeName))
                {
                    //Remind the user to not leave the field blank.
                    Console.WriteLine("Please do not leave this field blank. ");

                    //Re-prompt the user
                    Console.WriteLine("Please type in the name of recipe #{0}", i + 1);

                    //Listen for the user's input again using the same variable.
                    recipeName = Console.ReadLine();
                }
                //We also want to ask for the page # of each recipe.
                Console.WriteLine("Please type in the page # for the recipe: {0} ?", recipeName);

                string stringRecipePageNumber = Console.ReadLine();

                int recipePageNumber;
                //This while loop validates and ensure that the user can only input a number for the recipe page numbers.
                while (!int.TryParse(stringRecipePageNumber, out recipePageNumber) || recipePageNumber < 0)
                {
                    //Remind the user to not leave the field blank.
                    Console.WriteLine("Please do not leave this field blank. Please only enter in positive number values.");

                    //Re-prompt the user
                    Console.WriteLine("Please type in the page # for the recipe: {0} ?", recipeName);

                    //Listen for the user's input again using the same variable.
                    stringRecipePageNumber = Console.ReadLine();
                }
                favoriteRecipes.Add(recipeName, recipePageNumber);
                //The line below just tests in the user input is adding to the dictionary.
                //Console.WriteLine("This is the number of elements in our dictionary " + favoriteRecipes.Count);
            }

            Console.WriteLine("Great! Now I can keep track of your recipes!\r\n");

            Console.WriteLine("Your recipes are:");
            foreach (KeyValuePair<string, int> recipe in favoriteRecipes)
            {
                Console.WriteLine(recipe.Key);
            }

            Console.WriteLine("\r\nWhat recipe are you looking for?\r\n");

            Console.WriteLine("Choose from the above list:");

            string selectedRecipe = Console.ReadLine();

            int recipeSelected;

            while (!favoriteRecipes.TryGetValue(selectedRecipe, out recipeSelected))
            {
                Console.WriteLine("That recipe does not exist in our  dictionary.\r\nPlease make sure you type the recipe name exactly as it appears.");

                Console.WriteLine("\r\nWhat recipe are you looking for?\r\n");

                selectedRecipe = Console.ReadLine();
            }

            Console.WriteLine("You can find the {0} recipe on page #{1} of your cookbook. ",selectedRecipe, recipeSelected);
        }
    }
}