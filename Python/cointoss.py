def cointoss():
    import random
    headcounter = 0
    tailcounter = 0
    for x in range(1, 5001):
        randnum = random.randrange(0, 2)
        if randnum == 0:
            headcounter += 1
            print "Attempt #{}: Throwing a coin... It's a head! ... Got {} head(s) so far and {} tail(s) so far".format(x, headcounter, tailcounter)
        else:
            tailcounter += 1
            print "Attempt #{}: Throwing a coin... It's a tail! ... Got {} head(s) so far and {} tail(s) so far".format(x, headcounter, tailcounter)
cointoss()

