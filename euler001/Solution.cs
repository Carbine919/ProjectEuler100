using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    static void Main(String[] args) {
        int t = Convert.ToInt32(Console.ReadLine());
        for(int a0 = 0; a0 < t; a0++){
            int n = Convert.ToInt32(Console.ReadLine());
            n--;
            long a = n/3;
            long multiplesof3 = 3 * a*(a+1)/2;
            long b = n/5;
            long multiplesof5 = 5* b * (b+1)/2;
            long c = n/15;
            long multiplesof15 = 15 * c * (c+1)/2;
            long sum = multiplesof3+multiplesof5-multiplesof15;
        
        Console.WriteLine(sum);
        }
    }
}
