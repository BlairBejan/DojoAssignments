class mathdojo(object):
    def __init__(self):
        self.num = 0
    def add(self, *a):
        self.a = a
        for items in self.a:
            if isinstance(items, list) or isinstance(items, tuple):
                for num in items:
                    self.num += num
            else:
                self.num += items
        return self
    def subtract(self, *a):
        self.a = a
        for items in self.a:
            if isinstance(items, list) or isinstance(items, tuple):
                for num in items:
                    self.num -= num
            else:
                self.num -= items
        return self
    def result(self):
        print self.num

mathdojo().add([1],3,4).add((3,2), [2, 4.3, 1.25]).subtract(2, [2,3], [1.1, 2.3]).result()