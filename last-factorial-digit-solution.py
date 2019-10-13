def fact(n): #returns the factorial of an integer
  if n == 0:
    return 1
  else:
    return n * fact(n - 1)
cases = int(input()) #gets the number of cases
for i in range(cases):
  print(fact(int(input())) % 10) #returns the first digit
