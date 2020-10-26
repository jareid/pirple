using System;
using System.Collections.Generic;
using System.Text;

namespace Project1
{
    class Elevator
    {
        private readonly int MaxFloor;
        private readonly int MinFloor;
        public readonly String Name;
        public int CurrentFloor { get; private set; } = 0;
        public bool Travelling { get; private set; } = false;
        public bool TravellingDown { get; private set; } = false;
        private List<int> NextDownFloors = new List<int>();
        private List<int> NextUpFloors = new List<int>();
        public bool DoorsOpen { get; private set; } = false;
        private bool Moving = false;
        public event EventHandler ReachedFloor;
        public int TotalTime { get; private set; } = 0;

        protected virtual void OnFloorReached(EventArgs e)
        {
            EventHandler handler = ReachedFloor;
            handler?.Invoke(this, e);
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="minFloor">Lowest floor this elevator can reach</param>
        /// <param name="maxFloor">Highest floor this elevator can reach</param>
        /// <param name="name">Name of the elevator</param>
        public Elevator(int minFloor, int maxFloor, String name)
        {
            this.MaxFloor = maxFloor;
            this.MinFloor = minFloor;
            this.Name = name;
        }


        /// <summary>
        /// This function calls the elevator to the floor requested by a person, if the elevator is on this floor it will immediately open it's doors.
        /// </summary>
        /// <param name="floorNumber">The floor requested for the elevetor to pick up a person.</param>
        public void Call(int floorNumber)
        {
            AddFloor(floorNumber);
            Process();
            Console.WriteLine(Name + " > Has been called to floor" + floorNumber + " by a new person.");
            if (!Moving)
            {
                MoveOne();
            } 
        }

        /// <summary>
        /// This function opens the elevator doors allowing a passenger to board or alight.
        /// </summary>
        public void OpenDoors()
        {
            DoorsOpen = true;
            if (ReachedFloor != null)
            {
                ReachedFloor(this, null);
            }
            Console.WriteLine(Name + " > Opened Doors on Floor " + CurrentFloor);
        }

        /// <summary>
        ///  This Function allows a new person to select a floor once they enter the elevator.
        /// </summary>
        /// <param name="floorNumber"></param>
        public void SelectFloor(int floorNumber)
        {
            AddFloor(floorNumber);
            Process();
            Console.WriteLine(Name + " > Floor " + floorNumber + " has been selected by a new person.");
            MoveOne();
            CloseDoors();
        }

        /// <summary>
        /// This function begins the elevator moving from a standstill position.
        /// </summary>
        private void Process()
        {
            if (!Travelling)
            {
                Travelling = true;
                if (NextUpFloors.Count > 0)
                {
                    TravellingDown = false;

                } else if (NextDownFloors.Count > 0)
                {
                    TravellingDown = true;
                }
            }
        }

        /// <summary>
        /// This function moves the elevator a single floor, checks if a passenger needs to leave on this floor, opens the door to allow them to leave if so,
        /// and then decides whether it should continue moving down or switch to moving upwards for it's other passengers or stop moving.
        /// </summary>
        private void MoveOne()
        {
            AddTime();
            Moving = true;
            if (TravellingDown)
            {
                if (NextDownFloors[0] == CurrentFloor)
                {
                    if (!DoorsOpen)
                    {
                        OpenDoors();
                    }
                    NextDownFloors.RemoveAt(0);
                    CloseDoors();
                    ContinueMoving();
                    if (NextDownFloors.Count == 0)
                    {
                        TravellingDown = false;
                    }
                    if (CurrentFloor == Building.BASEMENT)
                    {
                        TravellingDown = false;
                    }
                }
                else
                {
                    CurrentFloor--;
                    MoveOne();
                }
            }
            else
            {
                if (NextUpFloors[0] == CurrentFloor)
                {
                    if (!DoorsOpen)
                    { 
                        OpenDoors();
                    }
                    NextUpFloors.RemoveAt(0);
                    CloseDoors();
                    ContinueMoving();
                    if (NextUpFloors.Count == 0)
                    {
                        TravellingDown = true;
                    }
                    if (CurrentFloor == Building.TOP_FLOOR)
                    {
                        TravellingDown = true;
                    }
                }
                else
                {
                    CurrentFloor++;
                    MoveOne();
                }
            }

            Console.WriteLine(Name + " > Moved to Floor " + CurrentFloor);
        }

        /// <summary>
        /// This function decides whether the elevator should continue moving or stop on the current floor
        /// </summary>
        private void ContinueMoving()
        {
            if (NextDownFloors.Count == 0 && NextUpFloors.Count == 0)
            {
                Travelling = false;
                Moving = false;
            }
            else
            {
                MoveOne();
            }
        }

        /// <summary>
        ///  This function shuts the doors of the elevator once a passenger has boarded or alighted.
        /// </summary>
        private void CloseDoors()
        {
            DoorsOpen = false;
            Console.WriteLine(Name + " > Closed Doors on Floor " + CurrentFloor);
        }

        private void AddFloor(int floorNumber)
        {
            if (Travelling)
            {
                if (TravellingDown)
                {
                    NextDownFloors.Add(floorNumber);
                    NextDownFloors.Sort();
                }
                else
                {
                    NextUpFloors.Add(floorNumber);
                    NextUpFloors.Sort();
                }
            } else
            {
                Travelling = true;
                if (floorNumber < CurrentFloor)
                {
                    NextDownFloors.Add(floorNumber);
                    TravellingDown = true;
                }
                else
                {
                    NextUpFloors.Add(floorNumber);
                    TravellingDown = false;
                }
            }
        }

        public bool GoesToFloor(int floorNum)
        {
            if (floorNum <= MaxFloor && floorNum >= MinFloor) { return true; }
            return false;
        }

        private void AddTime()
        {
            TotalTime++;
        }
    }
}
