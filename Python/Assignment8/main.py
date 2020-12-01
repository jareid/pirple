# -*- coding: utf-8 -*-
"""
Created on Fri Nov 20 11:21:01 2020

@author: jamie
"""
import os
        

filename = input("Please enter a filename: ")
if os.path.isfile(filename):
    print("A) Read the file")
    print("B) Delete the file and start over")
    print("C) Append the file")
    option = input("Please select an option: ")
    if option == "A":
        file = open(filename, "r")
        print(file.read())
        file.close();
    elif option == "B":
        note = input("Please enter the note: ")
        file = open(filename, "w")
        file.write(note)
        file.close()
    elif option == "C":
        note = input("Please enter the note: ")
        file = open(filename, "a")
        file.write(note)
        file.close()
    else:
        print("Unknown option. Exiting.")
else:
    note = input("Please enter the note: ")
    file = open(filename, "w")
    file.write(note)
    file.close()
    
    
