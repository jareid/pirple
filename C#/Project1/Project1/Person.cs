using System;
using System.Collections.Generic;
using System.Text;

namespace Project1
{
    class Person
    {
        private int OnFloor;
        private int FloorToGetTo;
        private Elevator Elevator;
        public int TimeTaken { get; private set; }
        private Building TheBuilding;

        public Person(int onFloor, int floorToGetTo, Building theBuilding)
        {
            this.OnFloor = onFloor;
            this.FloorToGetTo = floorToGetTo;
            this.TheBuilding = theBuilding;

            // with direction, a positive number indicates that the person wants to go down.
            //                 a negative number indicates they want to go up.
            int direction = OnFloor - FloorToGetTo;
            bool isUp = direction < 0 ? true : false;

            // Add 1 to Floor as our List is Zero indexed and our floors are -1 indexed
            Elevator elevator;
            if (isUp)
            {
                elevator = TheBuilding.Floors[OnFloor + 1].Up();
            }
            else
            {
                elevator = TheBuilding.Floors[OnFloor + 1].Down();
            }
            this.Elevator = elevator;
            elevator.ReachedFloor += this.SelectFloor;
            elevator.Call(OnFloor);


            // Calculate the time it will take to travel to your floor
            int distance = OnFloor - FloorToGetTo;
            if (distance < 0)
            {
                distance = -distance;
            }
            // Calculate the time it will take to arrive
            int timeToArrive = elevator.CurrentFloor - OnFloor;
            if (timeToArrive < 0)
            {
                timeToArrive = -timeToArrive;
            }
            // Add the two together to get the total time to travel.
            TimeTaken = timeToArrive + distance;
        }

        private void SelectFloor(object sender, EventArgs e)
        {
            if (((Elevator)sender).CurrentFloor == OnFloor)
            {
                Elevator.SelectFloor(FloorToGetTo);
            }
        }
    }
}
