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
        int N = Convert.ToInt32(Console.ReadLine());
        
       if( N%2 > 0)
           Console.WriteLine("Weird");
    
        if(N < 6 && N%2 == 0 )
            Console.WriteLine("Not Weird");
        if(N >=  6 && N <= 20 && N%2 == 0 )
            Console.WriteLine("Weird");
        if(N > 20 && N%2 == 0 )
            Console.WriteLine("Not Weird");
        
    }
}
