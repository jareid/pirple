using System;
using System.Collections.Generic;

namespace Project1
{
    class Program
    {
        private static readonly Random _random = new Random();

        private static int RandomNumber(int min, int max)
        {
            return _random.Next(min, max);
        }

        static void Main(string[] args)
        {
            Building theBuilding = new Building(180);
            List<Person> people = new List<Person>();
            for (int i = 0; i < 100; i++)
            {
                people.Add(new Person(RandomNumber(-1, 10), RandomNumber(-1, 10), theBuilding));
                if (theBuilding.GetTime() >= 180)
                {
                    break;
                }
            }
        }
    }
}
