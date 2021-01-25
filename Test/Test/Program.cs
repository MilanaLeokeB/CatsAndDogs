using System;
using System.IO;

namespace Test
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("enter the file name include extension:");
            string userInput = Console.ReadLine();
            CreateFileWithExtension(userInput);

        }
        public static void CreatNewFile()
        {
            string rootPath = @"C:\Users\opilane\samples\PlayerOne";
            string fileName = "ball.txt";
            File.Create(Path.Combine(rootPath, fileName));
        }
        public static void CreateUserFile(string fileName)
        {
            string rootPath = @"C:\Users\opilane\samples\PlayerTwo";
            File.Create(Path.Combine(rootPath, fileName));
        }
        public static void CreateFileWithExtension(string fileName)
        {
            string rootPath = @"C:\Users\opilane\samples\PlayerTwo";
            string fullfileName = $"{fileName}.txt";
            File.Create(Path.Combine(rootPath, fullfileName));
        }
    }
}
