time = [int(x) for x in input().split()]
time[1] -= 45
if(time[1] < 0):
  time[1] = 60 + time[1]
  time[0] -= 1
  if(time[0] == -1):
    time[0] = 23
print(" ".join([str(x) for x in time]))
