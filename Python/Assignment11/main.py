# -*- coding: utf-8 -*-
"""
Created on Tue Dec 29 10:27:13 2020

@author: jamie
"""

def compareInts(a,b,c):
    try:  
        a = int(a)
        b = int(b)
        c = int(c)
    except ValueError as e:
        print("One of the proivided arguments was not an integer")
        return False
    
    match = False
    if (a == b): 
        match = True
    elif (b == c):
        match = True
    elif (a == c):
        match = True
    else:
        match = False
	
    print(match)


compareInts("a",1,2)
compareInts("a","b",2)
compareInts(1,"b",2)
compareInts(1,2,"c")
compareInts(1,"b","c")
compareInts("a","b","c")
compareInts(1,1,2)
compareInts(1,1,1)
compareInts(1,2,3)
compareInts(2,"2",1)
compareInts(2,"1",1)
compareInts(2,"3",1)