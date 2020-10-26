using System;
using System.Text;

namespace Homework6
{
    class Vehicle
    {
        protected String Make;                        // Private variable to store the make of the vehicle
        protected String Model;                       // Private variable to store the model of the vehicle
        protected int Year;                           // Private variable to store the year of the vehicle
        protected double Weight;                      // Private variable to store the weight of the vehicle
        protected int TripsSinceMaintenance = 0;      // Private variable to store the status of the vehicle's trips since maintenance.
        protected Boolean NeedsMaintenance = false;   // Private variable to store the status of the vehicle's maintenance.

        /**
         * Sets the make of this vehicle
         **/
        public void setMake(String make)
        {
            this.Make = make;
        }

        // Returns the make of the Vehicle.
        public String getMake()
        {
            return this.Make;
        }

        /**
         * Sets the model of this vehicle
         **/
        public void setModel(String model)
        {
            this.Model = model;
        }

        // Returns the make of the Vehicle.
        public String getModel()
        {
            return this.Model;
        }

        /**
         * Sets the year of this vehicle
         **/
        public void setYear(int year)
        {
            this.Year = year;
        }

        // Returns the make of the Vehicle.
        public int getYear()
        {
            return this.Year;
        }

        /**
         * Sets the model of this vehicle
         **/
        public void setWeight(double weight)
        {
            this.Weight = weight;
        }

        // Returns the weight of the Vehicle.
        public double getWeight()
        {
            return this.Weight;
        }


        // Returns the weight of the Vehicle.
        public int getTripsSinceMaintenance()
        {
            return this.TripsSinceMaintenance;
        }


        // Returns the weight of the Vehicle.
        public Boolean getNeedsMaintenance()
        {
            return this.NeedsMaintenance;
        }

        public void Repair()
        {
            TripsSinceMaintenance = 0;
            NeedsMaintenance = false;
        }

        public String ToString()
        {
            StringBuilder sB = new StringBuilder();
            sB.Append("Make: ").Append(Make).Append("\n")
              .Append("Model: ").Append(Model).Append("\n")
              .Append("Year: ").Append(Year).Append("\n")
              .Append("Weight: ").Append(Weight).Append("\n")
              .Append("Trips Since Maintenance: ").Append(TripsSinceMaintenance).Append("\n")
              .Append("Needs Maintenance: ").Append(NeedsMaintenance).Append("\n");

            return sB.ToString();
        }
    }

    class Cars : Vehicle
    {
        protected bool isDriving = false;

        public void Drive()
        {
            if (!isDriving)
            {
                TripsSinceMaintenance++;
                isDriving = true;

                if (TripsSinceMaintenance > 100 && !NeedsMaintenance)
                {
                    NeedsMaintenance = true;
                }
            }
            else
            {
                Console.WriteLine("ERROR: This car is already driving so it can not be started!");
            }
        }

        public void Stop()
        {
            if (this.isDriving)
            {
                this.isDriving = false;
            }
            else
            {
                Console.WriteLine("ERROR: This car is not driving so it can not be stopped!");
            }
        }
    }

    class Planes : Vehicle
    {
        protected Boolean isFlying = false;

        public void Fly()
        {
            if (!isFlying)
            {
                if (NeedsMaintenance)
                {
                    Console.WriteLine("ERROR: This Plane needs maintenance and can not fly!");
                }
                else
                {
                    TripsSinceMaintenance++;
                    isFlying = true;

                    if (TripsSinceMaintenance > 100 && !NeedsMaintenance)
                    {
                        NeedsMaintenance = true;
                    }
                }
            }
            else
            {
                Console.WriteLine("ERROR: This plane is already flying so it can not take off again!");
            }
        }

        public void Land()
        {
            if (this.isFlying)
            {
                this.isFlying = false;
            }
            else
            {
                Console.WriteLine("ERROR: This plane is not flying so it can not make a landing!");
            }
        }

    }
    class Program
    {
        private static readonly Random _random = new Random();

        private static int RandomNumber(int min, int max)
        {
            return _random.Next(min, max);
        }

        static void Main(string[] args)
        {
            Cars carOne = new Cars();
            carOne.setMake("Ford");
            carOne.setModel("Fiesta");
            carOne.setYear(2018);
            carOne.setWeight(2.3);
            Cars carTwo = new Cars();
            carTwo.setMake("Mercedes Benz");
            carTwo.setModel("SL500");
            carTwo.setYear(2015);
            carTwo.setWeight(3.5);
            Cars carThree = new Cars();
            carThree.setMake("BMW");
            carThree.setModel("3 Series");
            carThree.setYear(2016);
            carThree.setWeight(3.1);

            Planes planeOne = new Planes();
            planeOne.setMake("Cessna");
            planeOne.setModel("Model A");
            planeOne.setYear(2020);
            planeOne.setWeight(0.8);
            Planes planeTwo = new Planes();
            planeTwo.setMake("Cessna");
            planeTwo.setModel("Model CW-6");
            planeTwo.setYear(2017);
            planeTwo.setWeight(1.1);
            Planes planeThree = new Planes();
            planeThree.setMake("Cessna");
            planeThree.setModel("Model CR-2");
            planeThree.setYear(2018);
            planeThree.setWeight(1.0);


            int carOneRuns = RandomNumber(25, 100);
            for (int i = 0; i < carOneRuns; i++)
            {
                carOne.Drive();
                carOne.Stop();
            }
            Console.WriteLine(carOne.ToString());
            Console.WriteLine("");

            int carTwoRuns = RandomNumber(100, 200);
            for (int i = 0; i < carTwoRuns; i++)
            {
                carTwo.Drive();
                carTwo.Stop();
            }
            Console.WriteLine(carTwo.ToString());
            Console.WriteLine("");

            int carThreeRuns = RandomNumber(50, 150);
            for (int i = 0; i < carThreeRuns; i++)
            {
                carThree.Drive();
                carThree.Stop();
            }
            Console.WriteLine(carThree.ToString());
            Console.WriteLine("");

            int planeOneRuns = RandomNumber(50, 125);
            for (int i = 0; i < planeOneRuns; i++)
            {
                planeOne.Fly();
                planeOne.Land();
            }
            Console.WriteLine(planeOne.ToString());
            Console.WriteLine("");

            int planeTwoRuns = RandomNumber(50, 125);
            for (int i = 0; i < planeTwoRuns; i++)
            {
                planeTwo.Fly();
                planeTwo.Land();
            }
            Console.WriteLine(planeTwo.ToString());
            Console.WriteLine("");

            int planeThreeRuns = RandomNumber(75, 125);
            for (int i = 0; i < planeThreeRuns; i++)
            {
                planeThree.Fly();
                planeThree.Land();
            }
            Console.WriteLine(planeThree.ToString());
        }
    }
}
