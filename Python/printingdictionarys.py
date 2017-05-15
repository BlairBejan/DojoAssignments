def printdict(x):
    for key, data in x.iteritems():
        print "My {} is {}".format(key, data)
printdict({"name": "Blair", "age": 20, "birth country": "usa", "favorite language": "python"})