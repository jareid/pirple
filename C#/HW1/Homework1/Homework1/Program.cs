using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pirple
{
    class Homework1 /* Naming the class based on which homework this is */
    {
        /*
         * 
         * This file is a homework peice for pirple.com. It is homework number 1.
         *  The question is: What's your favorite animal?
         *  The job of the hoemwork is to think of all the numerical attributes that you could use to describe that animal.
         */
        static void Main(string[] args) {
            const float KILO_TO_POUNDS_CONVERSION = 2.20462f;                   // Constant cointaining thge number of pounds in 1  kilo
            const double CM_TO_FEET_CONVERSION = 0.0328084;                     // Constant containing the number of feet in one centimetre
            const float MILES_TO_METRE_CONVERSION = 1609.34f;                   // Constant containing the number of metres in one mile
            const long SECOND_IN_YEAR_CONVERSION = 60 * 60 * 24 * 365;          // Constant containing the number of seconds in a year
            float weightInKilos = 17.5f;                                        // The wgight of the animal in kilograms
            float weightInPounds = weightInKilos * KILO_TO_POUNDS_CONVERSION;   // The weight of the animal converted to kilograms
            int heightInCM = 75;                                                // The height oif the animal in centrimetres
            double heightInFeet = 75 * CM_TO_FEET_CONVERSION;                   // The height of the animal converted to feet
            int numberOfTeeth = 42;                                             // The number of teeth the animal has
            bool isPredator = true;                                             // Boolean denoting if the animal is a predator or not.
            uint averageSpeed = 20;                                             // The speed of the animal in miles per hour
            double averageSpeedMetres = 20 * MILES_TO_METRE_CONVERSION;         // The speed of the animal in metres per hour
            ushort averageAgeYears = 13;                                        // The average age of the animal in years
            long averageAgeSeconds = 13 * SECOND_IN_YEAR_CONVERSION;            // The average age of the animal in seconds

            // Output the animals details to the console.
            string output = "Weight:" + weightInKilos + " kg";
            Console.WriteLine(output);
            output = "Weight:" + weightInPounds + " lbs";
            Console.WriteLine(output);

            output = "Height:" + heightInCM + " cm";
            Console.WriteLine(output);
            output = "Height:" + heightInFeet + " ft";
            Console.WriteLine(output);

            output = "Teeth:" + numberOfTeeth;
            Console.WriteLine(output);

            if (isPredator)
            {
                Console.WriteLine("Animal is a predator");
            }
            else
            {
                Console.WriteLine("Animal is not a predator");
            }

            output = "Speed:" + averageSpeed + "miles/hour";
            Console.WriteLine(output);
            output = "Speed:" + averageSpeedMetres + "m/hour";
            Console.WriteLine(output);

            output = "Age:" + averageAgeYears + "Years";
            Console.WriteLine(output);
            output = "Age:" + averageAgeSeconds + "Years";
            Console.WriteLine(output);
        }
    }
}
