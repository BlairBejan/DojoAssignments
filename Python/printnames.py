def printnames(x):
    for i in range(len(x)):
        name = ""
        for val in x[i].itervalues():
            name += val + " "
        print name

# printnames([
#      {'first_name':  'Michael', 'last_name' : 'Jordan'},
#      {'first_name' : 'John', 'last_name' : 'Rosales'},
#      {'first_name' : 'Mark', 'last_name' : 'Guillen'},
#      {'first_name' : 'KB', 'last_name' : 'Tonel'}
# ])

def printusers(x):
    for key in x.iterkeys():  #looping through keys in dict gives students, instructers
        print key
        for i in range(len(x[key])): # looping through each array in students and instructers
            name = ""
            for val in x[key][i].itervalues(): #looping through array indexes
                name += val + " "
            name = name[:-1].upper()
            print "{} - {} - {}".format(i, name, len(name)-1)
                


# printusers({
#  'Students': [
#      {'first_name':  'Michael', 'last_name' : 'Jordan'},
#      {'first_name' : 'John', 'last_name' : 'Rosales'},
#      {'first_name' : 'Mark', 'last_name' : 'Guillen'},
#      {'first_name' : 'KB', 'last_name' : 'Tonel'}
#   ],
#  'Instructors': [
#      {'first_name' : 'Michael', 'last_name' : 'Choi'},
#      {'first_name' : 'Martin', 'last_name' : 'Puryear'}
#   ]
#  })