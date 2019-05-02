values = [int(i) for i in input().split()]

if values[1] - values[0] > values[2] - values[1]:
  print(values[1] - values[0] - 1)
else:
  print(values[2] - values[1] - 1)
