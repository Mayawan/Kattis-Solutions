rate = 0
win = 0
for i in range(1,6):
  cont = sum([int(x) for x in input().split()])
  if(cont > rate):
    rate = cont
    win = i
print(str(win) + " " + str(rate))
