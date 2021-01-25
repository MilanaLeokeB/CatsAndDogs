using System;
using System.IO;

namespace FridayWorkWithFiles
{
    class Program
    {
        static void Main(string[] args)
        {

            static void Main(string[] args)
            {
                MoveFruits();
                MoveVegetables();
            }

            static void MoveFruits()
            {
                string sourceDirectory = @"C:\Users\opilane\samples\Friday";
                string destinationPath = @"C:\Users\opilane\samples\Friday\fruit";
                Console.WriteLine("What fruits would you like to move?");
                string userInput = Console.ReadLine();

                if (File.Exists(Path.Combine(sourceDirectory, userInput)))
                {
                    File.Move(Path.Combine(sourceDirectory, userInput), Path.Combine(destinationPath, userInput));
                    Console.WriteLine("File moved.");
                }
                else
                {
                    Console.WriteLine("File not found.");
                }


            }

             static void MoveVegetables()
            {
                string sourceDirectory = @"C:\Users\opilane\samples\Friday";
                string destinationPath = @"C:\Users\opilane\samples\Friday\vegetables";
                Console.WriteLine("What vegetables would you like to move?");
                string userInput = Console.ReadLine();

                if (File.Exists(Path.Combine(sourceDirectory, userInput)))
                {
                    File.Move(Path.Combine(sourceDirectory, userInput), Path.Combine(destinationPath, userInput));
                    Console.WriteLine("File moved.");
                }
                else
                {
                    Console.WriteLine("File not found.");
                }



            }
        }
    }
}
    

