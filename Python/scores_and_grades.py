def scoresandgrades():
    import random
    for i in range (10):
        tempnum = random.randrange(60, 100)
        if tempnum >= 60 and tempnum <= 69:
            print "Score: {}; Your grade is D".format(tempnum)
        elif tempnum >= 70 and tempnum <= 79:
            print "Score: {}; Your grade is C".format(tempnum)
        elif tempnum >= 80 and tempnum <= 89:
            print "Score: {}; Your grade is B".format(tempnum)
        elif tempnum >= 90 and tempnum <= 100:
            print "Score: {}; Your grade is A".format(tempnum)
    print "End of the program, Bye."
scoresandgrades()