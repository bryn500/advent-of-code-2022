import time
from solutions.day1 import *

filename = "../data.txt"

start = time.perf_counter()
 
result = solve(filename)
result2 = solve2(filename)
 
end = time.perf_counter()
 
print(result)
print(result2)
print(int(round((end-start)*1000)))
