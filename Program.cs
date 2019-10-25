using System;
using System.Collections.Generic;

namespace MovieList
{
    class Program
    {
        static void Main(string[] args)
        {
            bool goAgain = true;

            List<Movie> movieTitles = new List<Movie> 
            {
                new Movie("Finding Nemo", "Animated"),
                new Movie("Shrek", "Animated"),
                new Movie("Raw", "Horror"),
                new Movie("Halloween", "Horror"),
                new Movie("Evil Dead", "Horror"),
                new Movie("Star Wars", "Scifi"),
                new Movie("Guardians of the Galaxy", "Scifi"),
                new Movie("Men in Black", "Scifi"),
                new Movie("The Godfather", "Drama"),
                new Movie("Baby Driver", "Drama")
            };

            while (goAgain)
            {
                Console.Write("What kind of movie do you want to watch? (Pick a category. Animated, Horror, Scifi or Drama): ");
                string userInput = Console.ReadLine().ToLower();
                Console.WriteLine();

                Console.WriteLine($"Here are your movie choices:");

                for (int i = 0; i < movieTitles.Count; i++)
                {
                    if (userInput == movieTitles[i].Category.ToLower())
                    {
                        Console.WriteLine($"\t{movieTitles[i].Category}\n");
                    }
                }

                Console.Write("Would you like to pick another category? (y/n): ");
                string repeat = Console.ReadLine().ToLower();
                Console.WriteLine();

                if(repeat == "n")
                {
                    goAgain = false;
                }
            }
        }
    }
}
