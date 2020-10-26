using System;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool cakeIsChocOrVanilla = true;
            if (cakeIsChocOrVanilla)
            {
                Console.WriteLine("This cake is either vanilla or chocolate.");

                bool cakeIsChoc = false;
                if (!cakeIsChoc)
                {
                    Console.WriteLine("This cake is not chocolate.");
                }
                else
                {
                    Console.WriteLine("Therefore, this cake is vanilla.");
                }
            }

            bool allMenAreMortal = true;
            if (allMenAreMortal)
            {
                Console.WriteLine("All men are mortal");
                bool socratesIsMan = true;
                if (socratesIsMan)
                {
                    Console.WriteLine("Socrates is a man.");
                    if (allMenAreMortal && socratesIsMan)
                    {
                        Console.WriteLine("Therefore, socrates is mortal.");
                    }
                }
            }
        }
    }
}
