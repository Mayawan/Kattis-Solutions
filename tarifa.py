x = int(input())
n = int(input())

xn = x * (n + 1)

for i in range(n):
    xn -= int(input())
print(xn)
