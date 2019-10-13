input = input()                 #gets input
split_input = input.split()     #splits input

r1 = int(split_input[0])        #parses R1
s = int(split_input[1])           #parses S

"""
            Original Equation
            s = (r1 + r2) / 2
            Isolated r2 Equation
            r2 = 2s - r1
"""

r2 = 2 * s - r1                 #calculates R2

print(r2)                       #prints r2
