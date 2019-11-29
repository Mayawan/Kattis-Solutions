a = 1;
b = 0;
c = 0;
moves = input()

for i in moves:
  if(i == 'A'):
    a,b = b,a
  elif(i == 'B'):
    b,c = c,b
  else:
    a,c = c,a
if(a == 1):
  print(1)
elif(b == 1):
  print(2)
else:
  print(3)
