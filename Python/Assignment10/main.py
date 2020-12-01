# -*- coding: utf-8 -*-
"""
Python Homework 10
Created on Tue Dec  1 14:42:30 2020

@author: jamie
"""

import re

'''  Obtain the input for the expression and the text.''' 
text = input ("Please enter some text to have checked by the regular expresssion you enter:")
pattern = "^[A-Za-z0-9]{0,}$"

'''  Check the regexp is valid.
isRegexp = False
while (isRegexp):
    try:
      Pattern.compile(regexp)
      isRegex = True
    except re.error:
      isRegex = False
    regexp = input("You entered an invalid regular expression, please and enter it again: ");
''' 
    
''' Print out our inputs. ''' 
print("Valid regular expression entered:" , end='')
print(f"'{pattern}'")
print("Testing the expression on the following text:" , end='')
print(f"'{text}'")

'''  Try re.match ''' 
match = re.search(pattern, text)
if match:
    print("The provided expression matched some text on the provided input")
'''
if matched:
    print("The provided expression matched some text on the provided input")
else:
    print("The provided expression did not match any text on the provided input") 
'''

''' Try re.search  '''
searched = re.search(pattern,text)
s = searched.start()
e = searched.end()

print(f"Found {searched.re.pattern} in {searched.string} from {s} to {e} ({text[s:e]})")


    
        

    
