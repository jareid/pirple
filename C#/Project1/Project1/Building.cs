using System;
using System.Collections.Generic;
using System.Text;

namespace Project1
{
    class Building
    {
        public static int BASEMENT = -1;
        public static int TOP_FLOOR = 10;

        public Elevator ElevatorA = new Elevator(Building.BASEMENT, 9, "A");
        public Elevator ElevatorB = new Elevator(0, Building.TOP_FLOOR, "B");

        public List<Floor> Floors = new List<Floor>();

        private int TimeLeft = 0;

        public Building(int executeFor)
        {
            for (int i = BASEMENT; i < TOP_FLOOR; i++)
            {
                Floors.Add(new Floor(this, i));
            }

            TimeLeft = executeFor;
        }

        /// <summary>
        ///  This function returns the most efficient elevator to be used by a the call button
        /// </summary>
        /// <param name="isUp">Boolean denoting whether the person wants to find an elevator going up (true) or down (false)</param>
        /// <param name="floorCalledFrom">Integer denoting where the elevator is expected to be called from</param>
        /// <returns></returns>
        public Elevator CallNearestElevator(int floorCalledFrom)
        {
            // with distance a negative number indicates that the person is above the elevator and a positve indicates the person is below the elevator.
            int distanceA = ElevatorA.CurrentFloor - floorCalledFrom;
            int distanceB = ElevatorB.CurrentFloor - floorCalledFrom;

            if (distanceA > 0 && distanceB > 0)
            {
                if (ElevatorA.Travelling && ElevatorA.TravellingDown && ElevatorB.Travelling && ElevatorB.TravellingDown)
                {
                    if (distanceA < distanceB)
                    {
                        return ElevatorA.GoesToFloor(floorCalledFrom) ? ElevatorA : ElevatorB;
                    } else
                    {
                        return ElevatorB.GoesToFloor(floorCalledFrom) ? ElevatorB : ElevatorA;
                    }
                } else if (ElevatorA.Travelling && ElevatorA.TravellingDown)
                {
                    return ElevatorA.GoesToFloor(floorCalledFrom) ? ElevatorA : ElevatorB;
                } else if (ElevatorB.Travelling && ElevatorB.TravellingDown)
                {
                    return ElevatorB.GoesToFloor(floorCalledFrom) ? ElevatorB : ElevatorA;
                } else if (!ElevatorA.Travelling)
                {
                    return ElevatorA.GoesToFloor(floorCalledFrom) ? ElevatorA : ElevatorB;
                }
                else
                {
                    return ElevatorB.GoesToFloor(floorCalledFrom) ? ElevatorB : ElevatorA;
                }
            } else if (distanceA < 0 && distanceB < 0)
            {
                if (ElevatorA.Travelling && !ElevatorA.TravellingDown && ElevatorB.Travelling && !ElevatorB.TravellingDown)
                {
                    if (distanceA < distanceB)
                    {
                        return ElevatorA.GoesToFloor(floorCalledFrom) ? ElevatorA : ElevatorB; ;
                    }
                    else
                    {
                        return ElevatorB.GoesToFloor(floorCalledFrom) ? ElevatorB : ElevatorA;
                    }
                }
                else if (ElevatorA.Travelling && !ElevatorA.TravellingDown)
                {
                    return ElevatorA.GoesToFloor(floorCalledFrom) ? ElevatorA : ElevatorB; ;
                }
                else if (ElevatorB.Travelling && !ElevatorB.TravellingDown)
                {
                    return ElevatorB.GoesToFloor(floorCalledFrom) ? ElevatorB : ElevatorA;
                }
                else if (!ElevatorA.Travelling)
                {
                    return ElevatorA.GoesToFloor(floorCalledFrom) ? ElevatorA : ElevatorB; ;
                }
                else
                {
                    return ElevatorB.GoesToFloor(floorCalledFrom) ? ElevatorB : ElevatorA;
                }
            } else if (distanceA < 0)
            {
                return GoingUp(floorCalledFrom);
            }
            else if (distanceB < 0)
            {
                return GoingUp(floorCalledFrom);
            }
            else if (distanceA > 0)
            {
                return GoingDown(floorCalledFrom);
            }
            else if (distanceB > 0)
            {
                return GoingDown(floorCalledFrom);
            } else

            {
                return ElevatorA.GoesToFloor(floorCalledFrom) ? ElevatorA : ElevatorB; // return a default;
            }
        }

        private Elevator GoingDown(int floorCalledFrom)
        {
            if (ElevatorA.Travelling && ElevatorA.TravellingDown)
            {
                return ElevatorA.GoesToFloor(floorCalledFrom) ? ElevatorA : ElevatorB;
            }
            else if (ElevatorB.Travelling && ElevatorB.TravellingDown)
            {
                return ElevatorB.GoesToFloor(floorCalledFrom) ? ElevatorB : ElevatorA;
            }
            else if (!ElevatorA.Travelling)
            {
                return ElevatorA.GoesToFloor(floorCalledFrom) ? ElevatorA : ElevatorB;
            }
            else
            {
                return ElevatorB.GoesToFloor(floorCalledFrom) ? ElevatorB : ElevatorA;
            }
        }

        private Elevator GoingUp(int floorCalledFrom)
        {
            if (ElevatorA.Travelling && !ElevatorA.TravellingDown)
            {
                return ElevatorA.GoesToFloor(floorCalledFrom) ? ElevatorA : ElevatorB;
            }
            else if (ElevatorB.Travelling && !ElevatorB.TravellingDown)
            {
                return ElevatorB.GoesToFloor(floorCalledFrom) ? ElevatorB : ElevatorA;
            }
            else if (!ElevatorA.Travelling)
            {
                return ElevatorA.GoesToFloor(floorCalledFrom) ? ElevatorA : ElevatorB;
            }
            else
            {
                return ElevatorB.GoesToFloor(floorCalledFrom) ? ElevatorB : ElevatorA;
            }
        }

        public int GetTime()
        {
            int evA = ElevatorA.TotalTime;
            int evB = ElevatorB.TotalTime;

            return evA > evB ? evA : evB;
        }

    }
}
