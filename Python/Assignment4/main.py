myUniqueList = []
myLeftovers = []

def addToList(item):
	if item in myUniqueList:
		myLeftovers.append(item)
		return False
	else:
		myUniqueList.append(item)
		
addToList("Hello")
addToList("World")
addToList("World")
addToList("It")
addToList("Is")
addToList("Is")
addToList("A")
addToList("Great")
addToList("Day!")
addToList(35)
addToList("Degrees")
addToList(35)

print(myUniqueList)
print(myLeftovers)