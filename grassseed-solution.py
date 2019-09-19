C = float(input())
L = int(input())
totalLand = float(0)
for i in range(0,L):
  wl = [float(x) for x in input().split()]
  totalLand += wl[0] * wl[1]
print(totalLand * C)
