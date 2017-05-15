class product(object):
    def __init__(self, price, itemname, weight, brand, cost)
        self.price = price
        self.itemname = itemname
        self.weight = weight
        self.brand = brand
        self.cost = cost
        self.status = "for sale"
    def sell(self):
        self.status = "sold"
    def addtax(self, tax):
        print self.cost * tax
        return self
    def returnitem(self, reason):
        if reason = "defective":
            self.status = reason
            self.cost = 0
            return self
        elif reason = "inboxnew":
            self.status = "for sale"
            return self
        elif reason = "inboxopened":
            self.status = "used"
            self.cost *= 0.8
            return self