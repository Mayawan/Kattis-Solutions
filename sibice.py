import math
nwh = [int(x) for x in input().split()]
dia = math.sqrt(nwh[1] * nwh[1] + nwh[2] * nwh[2])
[print("DA" if int(input()) <= dia else "NE") for x in range(0,nwh[0])]
