n = int(input())
for i in range(0,n):
  rec = [int(x) for x in input().split()]
  r = rec[0]
  ec = rec[1] - rec[2]
  if(r < ec):
    print("advertise")
  elif(r > ec):
    print("do not advertise")
  else:
    print("does not matter")
