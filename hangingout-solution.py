lx = [int(x) for x in input().split()]
count = 0
denied = 0
for i in range(0,lx[1]):
  event = input().split()
  p = int(event[1])
  if(event[0] == "enter"):
    if(count + p > lx[0]):
      denied += 1
    else:
      count += p
  else:
    count -= p
print(denied)
