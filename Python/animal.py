class animal(object):
    def __init__(self, name, health):
        self.name = name
        self.health = health
    def walk(self):
        self.health -= 1
        return self
    def run(self):
        self.health -= 5
        return self
    def displayhealth(self):
        print "Name: {} Health: {}".format(self.name, self.health)
# myanimal = animal("myanimal", 100)
# myanimal.walk().walk().walk().run().run().displayhealth()

class dog(animal):
    def __init__(self, name):
        super(dog, self).__init__(name = name, health = 150)
        # self.health = 150
    def pet(self):
        self.health += 5
        return self

# mydog = dog("mydog")
# mydog.walk().walk().walk().run().run().pet().displayhealth()

class dragon(animal):
    def __init__(self, name):
        super(dragon, self).__init__(name = name, health = 170)
    def fly(self):
        self.health -= 10
        return self
    def displayhealth(self):
        print "this is a dragon"
        super(dragon, self).displayhealth()
        
# mydragon = dragon("mydragon")
# mydragon.walk().walk().walk().run().run().fly().fly().displayhealth()