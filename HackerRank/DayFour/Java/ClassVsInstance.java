import java.io.*;
import java.util.*;

public class Person {
  private int age;	

  public Person(int initialAge) {
    // Add some more code to run some checks on initialAge
      age = initialAge;
      // Add some more code to run some checks on initialAge
      if(age < 0){
          age = 0;
          System.out.println("Age is not valid, setting age to 0.");
      }
  }

  public void amIOld() {
    // Write code determining if this person's age is old and               print the correct statement:
       if(age < 0){
           
          System.out.println("Age is not valid, setting age to 0.");
      }
      if(age < 13){
          System.out.println("You are young.");
      }
      
      if(age >=13 && age < 18){
          System.out.println("You are a teenager.");
      }
       if(age >= 18){
          System.out.println("You are old.");
      }
  }

  public void yearPasses() {
    // Increment this person's age.
      age++;
  }
}