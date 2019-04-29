encoded = input()

length = len(encoded)
half = (int)(length / 2)

first = encoded[0:half]
second = encoded[half:length]

intFirst = [ord(i) - ord('A') for i in first]
intSecond = [ord(i) - ord('A') for i in second]

intFirst = [(i + sum(intFirst)) % 26 for i in intFirst]
intSecond = [(i + sum(intSecond)) % 26 for i in intSecond]

msg = ""

for i in range(half):
    msg += chr((intFirst[i] + intSecond[i]) % 26 + ord('A'))

print(msg)
