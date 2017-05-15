def typelist(x):
    string = ""
    sum = 0
    for i in range(len(x)):
        if isinstance(x[i], int) or isinstance(x[i], float):
            sum += x[i]
        elif isinstance(x[i], str):
            string += " " + x[i]
    if string != "" and sum != 0:
        print "mixed type"
    elif string == "" and sum != 0:
        print "integer type"
    elif string != "" and sum == 0:
        print "string type"
    print string
    print sum

# typelist(['magical','unicorns'])