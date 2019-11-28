def check(i, j, s, best):
  new = s[0:i][::-1]  + s[i:j][::-1] + s[j:][::-1]
  if(new < best):
    return new
  else:
    return best

s = input()
best = "z" * 50
for i in range(1,len(s) - 1):
  for j in range(i + 1, len(s)):
    best = check(i,j,s,best)
print(best)
