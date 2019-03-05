using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace CSharp_Shell
{

    public static class Program 
    {
        public static void Main(string[] args) 
        {
           int n = 1;
           OneToTen(n);
           
           
        }
        
       
        private static void OneToTen(int n)
            {
                Console.WriteLine(n);
                
                if (n < 10) {n++; OneToTen(n);}
                
            }
    }
}