n = int(input())
for i in range(0,n):
  bp = [float(x) for x in input().split()]
  x = 60 / bp[1]
  xb = x * bp[0]
  print(str(xb - x) + " " + str(xb) + " " + str(xb + x))
