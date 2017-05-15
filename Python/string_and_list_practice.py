# str = "It's thanksgiving day. It's my birthday,too!"
# print str.find("day")
# print str.replace("day", "month")

# def minmax(x):
#     newlist = []
#     print max(x)
#     newlist.append(max(x))
#     print min(x)
#     newlist.append(min(x))
#     print newlist
#     return

# minmax([10,2,3,4,5,6])

def sortarr(x):
    x.sort()
    print x
    temp_arr = []
    count = 0
    while count < (len(x)+1) / 2:
        temp_arr.append(x[count])
        count += 1
    x.insert(0, temp_arr)
    print temp_arr
    print x
    return

sortarr([19,2,54,-2,7,12,98,32,10,-3,6])