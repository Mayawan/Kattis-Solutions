a = input().split()
s = input().split()
u = True
game = int(a[1])
d = [int(i) for i in s]
if len(d) == 1:
    print(1)
else:
    d.sort()
    fff = 1
    for i in range(len(d) - 1):
        if d[i] + d[i+1] <= game:
            fff += 1
        else:
            print(fff)
            u = False
            break
    if u:
        print(fff)
