def findcharacters(x, y):
    new_arr = []
    for i in range(len(x)):
        if x[i].find(y) > 0:
            new_arr.append(x[i])
    print new_arr

# findcharacters(["this", "that", "the", "thing"], "i")