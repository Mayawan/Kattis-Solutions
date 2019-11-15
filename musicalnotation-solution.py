input()
notes = input().split()
pitches = "GFEDCBAgfedcba"
song = {}
for p in pitches:
  song[p] = ": "

for n in notes:
  pitch = n[0]
  duration = 1
  if(len(n) != 1):
    duration = int(n[1:])
  
  for key,val in song.items():
    fill = " "
    if(key in "FDBgea"):
      fill = "-"
    
    for i in range(duration):
      if(key == pitch):
        song[key] += "*"
      else:
        song[key] += fill;
    song[key] += fill

for key,val in song.items():
  print(key + val[:-1]);
