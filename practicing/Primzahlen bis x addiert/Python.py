import math
import datetime

i = 1
Eingabe = int(input("\n\nEingabe: "))

liste = []

date_a = datetime.datetime.now()

while (i < Eingabe):

    max = math.sqrt(i)
    i2 = 3
    Prime = True

    while (i2 <= max):
        if (i % i2 == 0):
            Prime = False
            break
        i2 += 2
    
    if (Prime):
        print(i)
        liste.append(i)
    
    i += 2

allNums = sum(liste) + 2

date_b = datetime.datetime.now()
time_delta = date_b - date_a

print("\n\nAlle Primzahlen bis ", Eingabe, " addiert: ", allNums, "\nDauer: ", time_delta, "\n\n")