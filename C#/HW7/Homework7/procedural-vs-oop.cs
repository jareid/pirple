using System;

namespace Homework7
{
    class Program
    {
        /*
         * In procedural programming, function is more important than data.
         * In object oriented programming, data is more important than function.
         */
         class Food
        {
            /*
             * There is no access specifier in procedural programming.
             * Object oriented programming have access specifiers like private, public, protected etc.
             * 
             * Procedural programming does not have any proper way for hiding data so it is less secure
             * Object oriented programming provides data hiding so it is more secure.
             */
            public String Name { get; private set; }

            public int Quantity { get; set; } = 0;

            public Food(String name)
            {
                this.Name = name;
            }
        }


        /*
         * Adding new data and function is not easy.
         * Adding new data and function is easy.
         */
        static void food(String name, int quantity)
        {
            Console.WriteLine("We have " + quantity + " " + name + "(s)");
        }


        static void Main(string[] args)
        {
            /*
             * In procedural programming, program is divided into small parts called functions.
             * In object oriented programming, program is divided into small parts called objects.
             * 
             * In procedural programming, function is more important than data.
             * In object oriented programming, data is more important than function.
             */
            Food apple = new Food("apple");
            apple.Quantity = 10;
            apple.Quantity += 15;
            Console.WriteLine("We have " + apple.Quantity + " " + apple.Name + "(s)");
            food("banana", 15);

            /**
             * It is better to use procedural programming in a non real world situation
             * and OOP in a real world situation where you need to model the objects of a "real world", such as a library
             * you would need to model the books, the tables, the shelves nbooks are stored on, the naming system, the librarian, the users, et cetera.
             * in procedural programming this would be very hard.
             * Prcoedural programming would be better when you need a simple application such as a calculator that needs to perform a number of easy repetitive functions.
             **/
        }
    }
}
