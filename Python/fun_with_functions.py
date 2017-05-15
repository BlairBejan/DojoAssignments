def odd_even():
    for i in range (1, 2001):
        if i % 2 == 0:
            print "number is {}. This is an even number".format(i)
        else:
            print "number is {}. This is an off number".format(i)
# odd_even()

def multiply(x, y):
    for i in range (len(x)):
        print x[i] * y
# multiply([1,2,3], 2)