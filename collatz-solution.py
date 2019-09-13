while(True):
  tempa, tempb = [int(i) for i in input().split()]
  if tempa== 0 and tempb == 0:
    break
  ar = {}
  a = tempa
  b = tempb
  steps = 0
  counter = 0
  while(True):
    ar[a] = counter
    if a == 1:
      break
    if a % 2 == 0:
      a = int(a/2)
    else:
      a = int((3*a) + 1)
    counter += 1
  while(True):
    if b in ar:
      numA = ar[b]
      print("{0} needs {1} steps, {2} needs {3} steps, they meet at {4}".format(tempa, numA, tempb, steps, int(b)))
      break
    if b % 2 == 0:
      b = int(b/2)
    else:
      b = int((3*b) + 1)
    steps += 1
