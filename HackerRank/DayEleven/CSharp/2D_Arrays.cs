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
        int[][] arr = new int[6][];

        for (int i = 0; i < 6; i++) {
            arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => 
                                      Convert.ToInt32(arrTemp));
        }
        
        //Create an array of integers
        int[] hourGlass = new int[16];
        int cshift = 0;   //represents the column that is shifted
        
        // Loop through the array
        for(int i = 0; i < 4; i++){ // 4 is the largest column index without running out of bounds
            for( int j = 0; j < 4; j++){  //  4 is the largest row index without running out of
                int sumTop = arr[i][j] + arr[i][j+1] + arr[i][j+2]; 
                int sumMiddle = arr[i+1][j+1];
                int sumBottom = arr[i+2][j] + arr[i+2][j+1] + arr[i+2][j+2];
                hourGlass[cshift] = sumTop + sumMiddle + sumBottom;
                cshift++;                            // Shift one column
            }
        }
        
        Console.WriteLine(hourGlass.Max());
        
    }
}
