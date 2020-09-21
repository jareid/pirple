//Rextester.Program.Main is the entry point for your code. Don't change it.
//Microsoft (R) Visual C# Compiler version 2.9.0.63208 (958f2354)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Rextester
{
    public class Program
    {
        /*
         * This file is a homework peice for pirple.com. It is homework number 1.
         *  The question is: What's your favorite animal?
         *  The job of the hoemwork is to think of all the numerical attributes that you could use to describe that animal.
         */
        public static void Main(string[] args)
        {
            string animalType = "Dog";                                          // The animal Type
            string animalName = "Cooper";                                       // The animal name
            float weightInKilos = 17.5f;                                        // The wgight of the animal in kilograms
            double weightInPounds = 38.5808576543;                               // The weight of the animal converted to kilograms
            int heightInCM = 75;                                                // The height oif the animal in centrimetres
            float heightInFeet = 2.46063f;                                      // The height of the animal converted to feet
            int numberOfTeeth = 42;                                             // The number of teeth the animal has                                        
            bool isPredator = true;                                             // boiolean if the animal is a predator or not
            string animalPrey = "rabbits";                                      // string describing the prey of the animal
            uint averageSpeed = 20;                                             // The speed of the animal in miles per hour
            short averageSpeedMetres = 32186;                                   // The speed of the animal in metres per hour
            ushort averageAgeYears = 13;                                        // The average age of the animal in years
            long averageAgeSeconds = 409968000;                                 // The average age of the animal in seconds

            // Output the animals details to the console.
            Console.WriteLine(animalType);
            Console.WriteLine(animalName);
            Console.WriteLine(weightInKilos);
            Console.WriteLine(weightInPounds);
            Console.WriteLine(heightInCM);
            Console.WriteLine(heightInFeet);
            Console.WriteLine(numberOfTeeth);
            Console.WriteLine(isPredator);
            Console.WriteLine(animalPrey);
            Console.WriteLine(averageSpeed);
            Console.WriteLine(averageSpeedMetres);
            Console.WriteLine(averageAgeYears);
            Console.WriteLine(averageAgeSeconds);
        }
    }
}