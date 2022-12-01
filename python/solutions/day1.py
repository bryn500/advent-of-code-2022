def getData(filename):
    with open(filename, "rt") as file: # close when done (e.g. c# using)
        groups = file.read().split('\n\n')
        return [sum(map(int, group.split('\n'))) for group in groups] # sum function applied to each in group, that converts each to int first

def solve(filename):
    data = getData(filename)
    return max(data)

def solve2(filename):
    data = getData(filename)
    order = sorted(data) # asc!
    top3 = order[-3:] # get the last three as a new array, can also be written as order[-3:len(order)], negative indexing + start/end indexing
    return sum(top3)
