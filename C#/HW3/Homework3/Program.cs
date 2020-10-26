using System;

namespace Homework3
{
    class Program
    {
        /**
         * The difference between a class and a structure is as follows
         * A structure is a value type so it is stored on the stack, but a class is a reference type and is stored on the heap.
         *
         *  A structure doesn't support inheritance, and polymorphism, but a class supports both.
         *
         *  By default, all the struct members are public but class members are by default private in nature.
         *
         *  As a structure is a value type, we can't assign null to a struct object, but it is not the case for a class.
         */
        public class Animal {
            public String _name;
            public int _speed = 0;

            public Animal() {
                _name = "animal";
            }

            public String sound() {
                return "mhmph";
            }

            public int speed()
            {
                return _speed;
            }
        }

        public class Dog : Animal
        {
            public Dog(int spd)
            {
                _name = "dog";
                _speed = spd;
            }

            public String sound()
            {
                return "woof";
            }

            public void startChasingRabbit()
            {
                _speed *= 5;
            }

            public void stopChasingRabbit()
            {
                _speed /= 5;
            }

        }
        //  The above is not possible with structs

        public struct _dog
        {
            public String sound;
            public int speed;

            public _dog(String sound, int speed)
            {
                this.sound = sound;
                this.speed = speed;
            }
        }


       static void Main(string[] args)
        {
            Dog dog = null; // structs can not be set to null

            _dog dog2 = new _dog("woof",5);


            // Use a struct when you want value semantics as opposed to reference semantics.
            // If your data structure needs no access control and has no special operations other than get/set, use a struct. This makes it obvious that all that structure is is a container for data.
            // i.e _dog vs Dog
            Console.WriteLine(dog2.speed);
            Console.WriteLine(dog.speed());
            dog.startChasingRabbit();
            Console.WriteLine(dog.speed());
            dog.stopChasingRabbit();
            Console.WriteLine(dog.speed());

        }
    }
}
