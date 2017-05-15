class car(object):
    def __init__(self, price, speed, fuel, mileage):
        self.price = price
        self.speed = speed
        self.fuel = fuel
        self.mileage = mileage
        if self.price > 10000:
            self.tax = 0.15
        else:
            self.tax = 0.12
        self.display_all()
    def display_all(self):
        print "Price: {}".format(self.price)
        print "Speed: {} MPH".format(self.speed)
        print "Fuel: {}".format(self.fuel)
        print "Mileage: {} MPG".format(self.mileage)
        print "Tax: {}".format(self.tax)
mycar1 = car(21230, 120, "empty", 50000)
mycar2 = car(20230, 120, "full", 50000)
mycar3 = car(12000, 120, "half", 50000)
mycar4 = car(2000, 80, "empty", 210000)
mycar5 = car(123000, 190, "full", 0)
mycar6 = car(230000, 250, "full", 0)
