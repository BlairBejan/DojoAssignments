def comparearr(x, y):
    count = 0
    if len(x) != len(y):
        print "The lists are not the same."
        return
    for i in range(len(x)):
        if x[i] != y[i]:
            print "The lists are not the same."
            break
        else:
            count += 1
            if count == len(x):
                print "The lists are the same"
comparearr([1,2,3], [1,2,3])