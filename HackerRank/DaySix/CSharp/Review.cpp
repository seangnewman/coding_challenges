using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int numberOfInputs = Int32.Parse(Console.ReadLine());
        
         
        for( var s = 0; s< numberOfInputs; s++) 
        {
            String initialString = Console.ReadLine();
            String strEven = "";
            String strOdd = "";
            
            for(var i = 0; i < initialString.Length; i++){
            if( i%2 == 0)
                strEven += initialString[i];
            else
                strOdd += initialString[i];
        }
        
        Console.WriteLine("{0} {1}", strEven, strOdd);
        }
       
        
        
        
    }
}