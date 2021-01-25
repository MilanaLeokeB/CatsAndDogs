using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SolarSystem
{
    class Program
    {
        public static IEnumerable<Item> PlanetItems { get; private set; }

        public class Item
            {
                string name;
                int mass;

                public Item(string _name, int _mass)
                {
                    name = _name;
                    mass = _mass;
                    Console.WriteLine($"Item:{name} created.");
                }

                public string Name { get { return name; } }
                public int TotalMass { get { return mass; } }
            }
            static void Main(string[] args)
            {
                PlanetFunction();
            }

        public static void PlanetFunction()
        {
            string filePath = @"C:\Users\opilane\samples";
            string fileName = @"SolarSystem.txt";


               List<Item> SolarSystemItems = new List<Item>();

                List<string> LinesFromFile = File.ReadAllLines(Path.Combine(filePath, fileName)).ToList();

                foreach (string line in LinesFromFile)
                {
                    string[] tempArray = line.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
                    Item newItem = new Item(tempArray[0], Int32.Parse(tempArray[1]));
                    SolarSystemItems.Add(newItem);
                }
            int total = 0;
            foreach (Item item in PlanetItems)
            {
                Console.WriteLine($"Planet: {item.Name} | Mass: {item.TotalMass}");
            }
                {
                    Console.WriteLine("Total planet mass:" + total);
                }
            }
        }
    }


