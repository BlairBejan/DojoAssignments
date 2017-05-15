def draw_stars(x):
    for i in range(len(x)):
        stars = "*"
        letters = ""
        if isinstance(x[i], int):
            print stars * x[i]
        elif isinstance(x[i], str):
            letters += x[i][0]
            print letters * len(x[i])
draw_stars([1,2,3,"hi",5,6,7,8,"tenletters",10])