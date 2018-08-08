using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        IDictionary<string, int> Solution = new Dictionary<string, int>();
        
        int numElem = Int32.Parse(Console.ReadLine());
        
        for(int i=0; i < numElem; i++){
            string temp = Console.ReadLine() ;
            string[] newTemp = temp.Split(' ');
            Solution.Add(newTemp[0], Int32.Parse(newTemp[1]));
            
        }
        
        
        
        for(int i=0; i < numElem; i++){
            var sKey = Console.ReadLine();
            
            if( Solution.ContainsKey(sKey)){
                Console.WriteLine("{0}={1}", sKey, Solution[sKey].ToString());
            }else{
                Console.WriteLine("Not found");
            }
        }
        
    }
}