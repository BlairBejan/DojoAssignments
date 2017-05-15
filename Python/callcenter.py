class call(object):
    def __init__(self, id, name, number, time, reason):
        self.id = id
        self.name = name
        self.number = number
        self.time = time
        self.reason = reason
    def display(self):
        print "Call ID: {}, Caller Name: {}, Phone Number: {}, Time of Call {}, Reason for Call {}".format(self.id, self.name, self.number, self.time, self.reason)
    def call(self):
        print {"id": self.id, "name": self.name, "number": self.number, "time": self.time, "reason": self.reason}

class callcenter(object):
    def __init__(self):
        self.calllist = []
        self.queuelength = len(self.calllist)
    def addcall(self, call):
        self.call = call
        self.calllist.append(dict(self.call))
        return self   #had a problem that if i didnt return self and added users in two different calls of the function they wouldnt append to my list they would just both be objects inside of their own lists
    def removecall(self):
        self.calllist.remove(self.calllist[0])
        return self
    def info(self):
        for index in self.calllist:
            print "Name: {}, Phone Number: {}, Queue Length {}".format(self.calllist[index]['name'], self.calllist[index]['number'], self.queuelength)
        return self

# call1 = call(000, "blairbejan", 2065277118, 2215, "tired").call()
# callcenter1 = callcenter().addcall({'reason': 'tired', 'time': 2215, 'number': "2065277118", 'id': 0, 'name': 'blairbejan'}).addcall({'reason': 'cool', 'time': 2115, 'number': "0000000000", 'id': 1, 'name': 'blakebejan'}).info()
