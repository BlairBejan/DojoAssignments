class bike(object):
    def __init__(self, price, max_speed):
        self.price = price
        self.max_speed = max_speed
        self.miles = 0
    def displayinfo(self):
        # return self.price
        print self.price
        print self.max_speed
        print self.miles
    def ride(self):
        print "riding"
        self.miles += 10
        return self
    def reverse(self):
        print "reversing"
        if self.miles >= 5:
            self.miles -= 5
        else:
            return self
        return self

bike1 = bike(250, 30)
bike1.ride().ride().ride().reverse().displayinfo()

bike2 = bike(500, 60)
bike2.ride().ride().reverse().reverse().displayinfo()

bike3 = bike(5000, 120)
bike3.reverse().reverse().reverse().displayinfo()
