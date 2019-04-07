import math
from decimal import *
while(True):
  try:
    curve1 = [Decimal(i) for i in input().split()]
    if len(curve1) == 0:
      break
    curve2 = [Decimal(i) for i in input().split()]
  except:
    break
  finalCurve = []
  for i in range(len(curve1)):
    finalCurve.append(curve2[i] - curve1[i])
  d = [finalCurve[1], finalCurve[2] * 2, finalCurve[3] * 3]

  discrim = (d[1] * d[1]) - (4 * d[2] * d[0])

  b = []
  solution = []
  try:
    if not d[2] == 0:
      if discrim >= 0:
        b.append((-d[1] + Decimal(math.sqrt(discrim)))/ (2 * d[2]))
        b.append((-d[1] - Decimal(math.sqrt(discrim)))/ (2 * d[2]))
      for s in b:
        if s < 1 and s > 0:
          solution.append(finalCurve[0] + (finalCurve[1] * s) + (finalCurve[2] * Decimal(math.pow(s, 2))) + finalCurve[3] * Decimal(math.pow(s,3)))
    else:
      if not d[1] == 0:
        s = (-d[0]/d[1])
        if s < 1 and s > 0:
            solution.append(finalCurve[0] + (finalCurve[1] * s) + (finalCurve[2] * Decimal(math.pow(s, 2))) + finalCurve[3] * Decimal(math.pow(s,3)))
  except:
    pass
  solution.append(finalCurve[0])
  solution.append(finalCurve[0] + finalCurve[1] + finalCurve[2] + finalCurve[3])
  small = min(solution)
  big = max(solution)
  print(big-small)
