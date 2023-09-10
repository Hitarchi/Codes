word = str(input("Enter string:"))
notChar = 0
isChar = 0
for char in word:
    if not char.isalpha():
        notChar += 1
    else:
        isChar += 1
print(isChar, " were letters; ", notChar, " were not letters.")