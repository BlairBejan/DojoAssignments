def printoddnum1to1000():           #defining function that prints odd numbers 1 - 1000
    for count in range(1, 1001): #itterating through all possible odds in range meant to print
        if count % 2 == 1:  #determining if count is an odd number
            print count    #printing count if its odd

# printoddnum1to1000()

def printmultof5tomil():  #function that prints multiples of 5 from 1 to 1 million
    for count in range(5, 1000001):
        if count % 5 == 0:  #checks if multiple of 5
            print count     #prints if is

# printmultof5tomil()

def sumofarrvals(x):    #gets sum of all values in array
    count_num = 0       #counter
    for count in range(len(x)): #itterates through array adds value to count as it goes
        count_num += x[count]
    print count_num

# sumofarrvals([1, 2, 5, 10, 255, 3])

def avgsumofarrvals(x):     #gets avg of all values in array
    avg_num = 0             #counter
    for count in range(len(x)): #adds all values to counter then devides the counter by how many values in the array there were
        avg_num += x[count]
    avg_num /= len(x)
    print avg_num

# avgsumofarrvals([1, 2, 5, 10, 255, 3])