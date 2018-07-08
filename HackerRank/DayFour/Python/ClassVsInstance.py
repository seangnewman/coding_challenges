class Person:
    def __init__(self,initialAge):
        # Add some more code to run some checks on initialAge
        self._age = initialAge
        if (self._age < 0):
          self._age = 0
          print("Age is not valid, setting age to 0.")   
           
    def amIOld(self):
        # Do some computations in here and print out the correct statement to the console
        if (self._age < 13):
          print("You are young.")
        if (self._age >= 13 and self._age < 18): 
          print("You are a teenager.")
        if (self._age >= 18): 
          print("You are old.")
    def yearPasses(self):
        # Increment the age of the person in here
        self._age +=  1