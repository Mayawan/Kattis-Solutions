t = int(input())
for i in range(0,t):
  n = int(input())
  log = [input() for x in range(0,n)]
  distinct = list(set(log))
  print(len(distinct))
