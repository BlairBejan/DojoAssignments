import patient
class patient(object):
    def __init__(self, id, name, allergies):
        self.id = id
        self.name = name
        self.allergies = allergies
        self.bednumber = "none"

class hospital(patient):
    def __init__(self, name, capacity):
        self.name = name
        self.capacity = capacity
        self.patients = []
    def admit(self, patient):
        super(hospital, self).__init__()
        if len(self.patients) >= capacity:
            print "Hospital is full"
        else:
            self.patients.append({"id": self.id, "name": self.name, "allergies": self.allergies})
            self.bednumber = "12"
            print "Admitted, your bed number is {}".format(self.bednumber)
        return self
    def discharge(self, patientname):
        self.patientname = patientname
        for index in self.patients:
            if self.patients[index]["name"] is self.patientname:
                self.patients.remove(self.patients[index])
                self.bednumber = "none"

newpatient = patient("1", "john", "peanuts")
newhospital = hospital("sacred heart", 1000).admit(newpatient)