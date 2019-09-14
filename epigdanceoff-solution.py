nm = [int(x) for x in input().split()]
dance = [input() for x in range(0,nm[0])]
rating = 1;
for i in range(0,nm[1]):
  col = "".join([x[i] for x in dance])
  if(col == nm[0]*"_"):
    rating += 1
print(rating)
