
def DrawGrid(rows, columns):
    for row in range(rows):
        if row%2 == 0:
            for column in range(1, columns):
                if column%2 == 1:
                    if column != columns-1:
                        print(" ", end="")
                    else:    
                        print(" ")
                else:
                    if column != columns-1:     
                        print("|", end="")
                    else:    
                        print("|")
        else:
            print("-"*rows)

rows = int(input("Enter your number of rows: "))
columns = int(input("Enter your number of columns: "))

DrawGrid(rows,columns)