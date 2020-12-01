# -*- coding: utf-8 -*-
"""
Created on Mon Nov 23 09:40:18 2020

@author: jamie
"""

class Vehicle:
    def __init__(self,Make,Model,Year,Weight):
        self.Make = Make
        self.Model = Model
        self.Year = Year
        self.Weight = Weight
        self.TripsSinceMaintenance = 0
        self.NeedsMaintenance = False

    def setMake(self,Make):
        self.Make = Make;

    def setModel(self, Model):
        self.Model = Model;

    def setYear(self, Year):
        self.Year = Year;

    def setWeight(self, Weight):
        self.Weight = Weight;


    def Repair(self):
        self.TripsSinceMaintenance = 0;
        self.NeedsMaintenance = false;

    def Print(self):
        print(f"Make: {self.Make}")
        print(f"Model: {self.Model}")
        print(f"Year: {self.Year}")
        print(f"Weight: {self.Weight}")
        print(f"Trips Since Maintenance: {self.TripsSinceMaintenance}")
        print(f"Needs Maintenance: {self.NeedsMaintenance}")

class Cars(Vehicle):
    def __init__(self,Make,Model,Year,Weight):
        Vehicle.__init__(self, Make, Model, Year, Weight)
        self.IsDriving = False;

    def Drive(self):
        if (not self.IsDriving):
            TripsSinceMaintenance += 1;
            isDriving = true;

            if TripsSinceMaintenance > 100 and not NeedsMaintenance:
                NeedsMaintenance = true;
        else:
            print("ERROR: This car is already driving so it can not be started!")

    def Stop(self):
        if (self.isDriving):
            this.isDriving = false;
        else:
            print("ERROR: This car is not driving so it can not be stopped!")
            
    def Print(self):
        Vehicle.Print(self);
        print(f"isDriving: {self.IsDriving}")

class Planes(Vehicle):
    def __init__(self,Make,Model,Year,Weight):
        Vehicle.__init__(self, Make, Model, Year, Weight)
        self.IsFlying = False;

    def Fly(self):
        if (not self.IsFLying):
            if (self.NeedsMaintenance):
                print("ERROR: This Plane needs maintenance and can not fly!")
            else:
                TripsSinceMaintenance += 1;
                isDriving = true;

            if TripsSinceMaintenance > 100 and not NeedsMaintenance:
                NeedsMaintenance = true;
        else:
            print("ERROR: This plane is already flying so it can not take off again!")

    def Land(self):
        if (self.isFlying):
            this.isFlying = false;
        else:
            print("ERROR: This plane is not flying so it can not make a landing!")

    def Print(self):
        Vehicle.Print(self);
        print(f"isFlying: {self.IsFlying}")
    

carOne = Cars("Ford","Fiesta", 2018, 2.3);
carOne.Print()
carTwo = Cars("Mercedes Benz","SL500",2015,3.5);
carTwo.Print()
carThree = Cars("BMW","3 Series",2016,3.1);
carThree.Print()

planeOne = Planes("Cessna","Model A",2020,0.8);
planeOne.Print()
planeTwo = Planes("Cessna","Model CW-6",2017,1.1);
planeTwo.Print()
planeThree = Planes("Cessna","Model CR-2",2018,1.0);
planeThree.Print()

