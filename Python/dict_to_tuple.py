def dicttotuple(x):
    tuplelist = []
    for i in x.items():
        tuplelist.append(i)
    print tuplelist
dicttotuple( {
  "Speros": "(555) 555-5555",
  "Michael": "(999) 999-9999",
  "Jay": "(777) 777-7777"
})