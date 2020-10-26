def compareInts(a,b,c):
	a = int(a)
	b = int(b)
	c = int(c)
	match = False;
	if (a == b): 
		match = True
	elif (b == c):
		match = True
	elif (a == c):
		match = True;
	else:
		match = False;
	
	return match

print(compareInts(1,1,2))
print(compareInts(1,1,1))
print(compareInts(1,2,3))
print(compareInts(2,"2",1))
print(compareInts(2,"1",1))
print(compareInts(2,"3",1))

