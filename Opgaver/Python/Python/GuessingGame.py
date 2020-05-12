class Guessing_game(object):
    """description of class"""
    import random

    rand = random.randrange(0, 10)
    guess = 0

    while guess != str(rand):
        guess = input("Guess a random number between 0 & 10: ")

print("You did it, yaay")



