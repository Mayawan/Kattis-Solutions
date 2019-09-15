n = int(input())
qaly = 0
for i in range(0,n):
  qy = [float(x) for x in input().split()]
  qaly += qy[0] * qy[1]
print(qaly)
