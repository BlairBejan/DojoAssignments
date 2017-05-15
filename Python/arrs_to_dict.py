# def arrtodict(x, y):
#     my_dict = dict(zip(x, y))
#     print my_dict

def arrtodict(x, y):
    if len(x) > len(y):
        my_dict = dict(zip(x, y))
    else:
        my_dict = dict(zip(y, x))
    print my_dict
arrtodict(["Anna", "Eli", "Pariece", "Brendan", "Amy", "Shane", "Oscar"], 
    ["horse", "cat", "spider", "giraffe", "ticks",])