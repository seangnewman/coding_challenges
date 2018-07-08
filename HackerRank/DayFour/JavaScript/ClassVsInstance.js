function Person(initialAge) {
  // Add some more code to run some checks on initialAge
  age = initialAge;
  // Add some more code to run some checks on initialAge
  if (age < 0) {
    age = 0;
    console.log("Age is not valid, setting age to 0.");
  }
  this.amIOld = function () {
    if (age < 0) {
      console.log("Age is not valid, setting age to 0.");
    }
    if (age < 13) {
      console.log("You are young.");
    }

    if (age >= 13 && age < 18) {
      console.log("You are a teenager.");
    }
    if (age >= 18) {
      console.log("You are old.");
    }
  };
  this.yearPasses = function () {
    age++;
  };
}
