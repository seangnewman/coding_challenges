class Person {
    public int age;     
	public Person(int initialAge) {
         age = initialAge;
        // Add some more code to run some checks on initialAge
        if(age < 0){
            age = 0;
            Console.WriteLine("Age is not valid, setting age to 0.");
        }
        
     }
     public void amIOld() {
        // Do some computations in here and print out the correct statement to the console 
         if(age < 0){
             
            Console.WriteLine("Age is not valid, setting age to 0.");
        }
        if(age < 13){
            Console.WriteLine("You are young.");
        }
        
        if(age >=13 && age < 18){
            Console.WriteLine("You are a teenager.");
        }
         if(age >= 18){
            Console.WriteLine("You are old.");
        }
        
     }

     public void yearPasses() {
        // Increment the age of the person in here
         age++;
     }
}