using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution {



    static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        
         int remainder = 0; int tempAccumulator = 0; int Accumulator = 0;
    
      while(n > 0)
      {
        remainder = n % 2;
        n = n >> 1;
        if( remainder == 1){
          tempAccumulator++;
          if(tempAccumulator > Accumulator)
          {
            Accumulator = tempAccumulator;
          }
       }
        else{
           tempAccumulator = 0;  
        }
     
    }
    
    Console.WriteLine(Accumulator);

    }
}
