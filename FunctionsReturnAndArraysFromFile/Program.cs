using System;

namespace FunctionsReturnAndArraysFromFile
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayRandomFood();
            DisplayRandomDrink();
            DisplayRandomMovie();
        }

        private static void DisplayRandomFood()
        {
            string[] foods = { "pizza", "sushi", "kebab", "chicken", "meat" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, foods.Length);

            string randomFood = foods[randomIndex];
            Console.WriteLine($"Computer picked: {randomFood}");

        }

        private static void DisplayRandomDrink()
        {
            string[] drinks = { "milk", "coke", "banana juice", "sprite", "Kane's" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, drinks.Length);

            string randomDrink = drinks[randomIndex];
            Console.WriteLine($"Computer picked: {randomDrink}");

        }

        private static void DisplayRandomMovie()
        {
            string[] movies = { "LOTR", "The Hobbit", "The Incredibles", "The Smurfs", "Trolls" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, movies.Length);

            string randomMovie = movies[randomIndex];
            Console.WriteLine($"Computer picked: {randomMovie}");

        }
    }
}
