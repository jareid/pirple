using System;
using System.Collections.Generic;
using System.Text;

namespace Project1
{
    class Floor
    {
        int FloorNumber = 0;
        Building TheBuilding;

        public Floor(Building theBuilding, int floorNumber)
        {
            this.TheBuilding = theBuilding;
            this.FloorNumber = floorNumber;
        }

        /// <summary>
        /// Calls the Elevator to a floor higher up in the building
        /// </summary>
        /// <returns>returns one of the two elevators, whichever is the most efficient</returns>
        public Elevator Up()
        {
            if (FloorNumber == Building.TOP_FLOOR)
            {
                return null;
            }
            return TheBuilding.CallNearestElevator(FloorNumber);
        }

        /// <summary>
        /// Calls the Elevator to a floor lower down in the building
        /// </summary>
        /// <returns>returns one of the two elevators, whichever is the most efficient</returns>
        public Elevator Down()
        {
            if (FloorNumber == Building.BASEMENT)
            {
                return null;
            }
            return TheBuilding.CallNearestElevator(FloorNumber);
        }
    }
}
