using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Threading;

namespace CSharp_Shell
{

    public static class Program 
    {
        public static void Main() 
        {
           
           // creating a two ordinary 'string[]' arrays
           string[] hebrewNumbers = new string[12];
           hebrewNumbers[0] =  "אפס";
           hebrewNumbers[1] = "אחד";
           hebrewNumbers[2] = "שתים";
           hebrewNumbers[3] = "שלוש";
           hebrewNumbers[4] = "ארבע";
           hebrewNumbers[5] = "חמש";
           hebrewNumbers[6] = "שש";
           hebrewNumbers[7] = "שבע";
           hebrewNumbers[8] = "שמונה";
           hebrewNumbers[9] = "תשע";
           hebrewNumbers[10] = "עשר";
           hebrewNumbers[11] = "אחד עשרה";
           
           
           string[] englishNumbers = new string[12];
           englishNumbers[0] = "Zero";
           englishNumbers[1] = "One";
           englishNumbers[2] = "Two";
           englishNumbers[3] = "Three";
           englishNumbers[4] = "Four";
           englishNumbers[5] = "Five";
           englishNumbers[6] = "Six";
           englishNumbers[7] = "Seven";
           englishNumbers[8] = "Eight";
           englishNumbers[9] = "Nine";
           englishNumbers[10] = "Ten";
           englishNumbers[11] = "Eleven";
           
          
           // declaring a jagged aray
           string[][] mlngNames = new string[2][]; //declaring a nrw jagged array of 2 arrays
           
           
            // filling the jagged arrayvwith values using the previously created plain arrays
            mlngNames[0] = new string[hebrewNumbers.Length]; //declaring a new array that is a first of the jagged array
            for (int i = 0; i < hebrewNumbers.Length; i++)   
                {
                    mlngNames[0][i] = hebrewNumbers[i];
                }
           
            mlngNames[1] = new string[englishNumbers.Length]; //declaring a new array that is a second of the jagged array
            for (int i = 0; i < englishNumbers.Length; i++)
                {
                    mlngNames[1][i] = englishNumbers[i];
                }
        
         
        //int @caseSwitch = PleaseEnterSomeNumbers(1)[0];
        
        int outOfRangeCount = 0;
        string message1 = "\n-----------------------\nYou checked the number ";    
        Console.WriteLine(PrintNumber1To10(PleaseEnterSomeNumbers(1)[0], mlngNames, ref outOfRangeCount) ? $"\n{message1} only ONCE." : $"\n{message1} {outOfRangeCount} times.");
        Thread.Sleep(1000);
        Console.WriteLine("AND NOW!");
        
        Console.BackgroundColor = ConsoleColor.Yellow;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Do you want to try ONLY ONCE again? ");
        Thread.Sleep(1000);
        
        if(onlyYesOrNo(ref outOfRangeCount)) {Console.ResetColor(); PrintNumber1To10(PleaseEnterSomeNumbers(1)[0], mlngNames, ref outOfRangeCount);}
        
        Console.BackgroundColor = ConsoleColor.Green;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine("---------------------");
         
        Console.ResetColor();
        
            
            
            
            
            
            
        }   
        
            
            
        private static bool PrintNumber1To10(int @caseSwitch, string[][] mlngNames, ref int outOfRangeCount)  
        {   
            
            
            TryAgain:
            
            
            switch (@caseSwitch)
                {
                case 0:
                    Console.WriteLine($" The number {@caseSwitch} in English is {mlngNames[1][0]}. So in Hebrew it's {mlngNames[0][0]}");
                    return true;
                    break;
                case 1:
                    Console.WriteLine($" The number {@caseSwitch} in English is {mlngNames[1][1]}. So in Hebrew it's {mlngNames[0][1]}");
                    return true;
                    break;
                case 2:
                    Console.WriteLine($" The number {@caseSwitch} in English is {mlngNames[1][2]}. So in Hebrew it's {mlngNames[0][2]}");
                    return true;
                    break;
                case 3:
                    Console.WriteLine($" The number {@caseSwitch} in English is {mlngNames[1][3]}. So in Hebrew it's {mlngNames[0][3]}");
                    return true;
                    break;
                case 4:
                    Console.WriteLine($" The number {@caseSwitch} in English is {mlngNames[1][4]}. So in Hebrew it's {mlngNames[0][4]}");
                    return true;
                    
                case 5:
                    Console.WriteLine($" The number {@caseSwitch} in English is {mlngNames[1][5]}. So in Hebrew it's {mlngNames[0][5]}");
                    return true;
                    
                case 6:
                    Console.WriteLine($" The number {@caseSwitch} in English is {mlngNames[1][6]}. So in Hebrew it's {mlngNames[0][6]}");
                    return true;
                    
                case 7:
                    Console.WriteLine($" The number {@caseSwitch} in English is {mlngNames[1][7]}. So in Hebrew it's {mlngNames[0][7]}");
                    return true;
                    
                case 8:
                    Console.WriteLine($" The number {@caseSwitch} in English is {mlngNames[1][8]}. So in Hebrew it's {mlngNames[0][8]}");
                    return true;
                    
                case 9:
                    Console.WriteLine($" The number {@caseSwitch} in English is {mlngNames[1][9]}. So in Hebrew it's {mlngNames[0][9]}");
                    return true;
                    
                case 10:
                    Console.WriteLine($" The number {@caseSwitch} in English is {mlngNames[1][10]}. So in Hebrew it's {mlngNames[0][10]}");
                    return true;
                    
                case 11:
                    Console.WriteLine($" The number {@caseSwitch} in English is {mlngNames[1][11]}. So in Hebrew it's {mlngNames[0][11]}");
                    return true;
                    
                default:
                    Console.WriteLine("Number not in range!!! \n");
                    if(onlyYesOrNo(ref outOfRangeCount)) {PrintNumber1To10(PleaseEnterSomeNumbers(1)[0], mlngNames, ref outOfRangeCount);}
                    return false;
                    
                }
            
            
        }
        
        private static bool onlyYesOrNo(ref int outOfRangeCount)
        {   Console.WriteLine("If you want to try again enter \"y\". If you want to stop enter \"n\".\n");
            EnterYorN:
            string yn = Console.ReadLine();
            outOfRangeCount++;
            if (yn == "y") {return true;}
            else if (yn == "n") {Console.WriteLine("We had a good time together, good bye!"); return false;}
            else {Console.WriteLine("Please enter only \"y\" or \"n\" and nothing else!"); goto EnterYorN;}
        }
        
        static int[] PleaseEnterSomeNumbers(int iterations)
        {

            if (iterations == 1) { Console.WriteLine("Please enter one number between 0 and 11:\n"); }
            else { Console.WriteLine("Please enter {0} numbers:\n", iterations); }

            int[] arriterations = new int[iterations];

            for (int i = 0; i < iterations; i++)
            {
                if (i > 0) { Console.Clear(); }
                if (i != 0) { Console.WriteLine("Please enter a number: \n"); }
                int line;
            EnterNumber:
                if (Int32.TryParse(Console.ReadLine(), out line)) { arriterations[i] = line; }
                else { Console.WriteLine("\n This is not a number! \nPlease enter only numbers. \nNow lets try again: \n"); goto EnterNumber; }
                //Console.Clear();
            }

            return arriterations;
        }
    }
}