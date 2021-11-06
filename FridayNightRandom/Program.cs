using System;

namespace FridayNightRandom
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayRandomFood();
            DisplayRandomDrink();
            DisplayRandomMovie();
        }

        private static int GenerateRandomIndex(string[] someArray)
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, someArray.Length);

            return randomIndex;
        }

        private static void DisplayRandomFood()
        {
            string[] foods = { "pizza", "sushi", "kebab", "chicken", "meat" };

            Console.WriteLine($"Computer picked: {foods[GenerateRandomIndex(foods)]}");

        }

        private static void DisplayRandomDrink()
        {
            string[] drinks = { "milk", "coke", "banana juice", "sprite", "Kane's" };

            Console.WriteLine($"Computer picked: {drinks[GenerateRandomIndex(drinks)]}");

        }

        private static void DisplayRandomMovie()
        {
            string[] movies = { "LOTR", "The Hobbit", "The Incredibles", "The Smurfs", "Trolls" };
            
            Console.WriteLine($"Computer picked: {movies[GenerateRandomIndex(movies)]}");

        }
    }
}
