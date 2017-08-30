using System;
using BDSA2017.Assignment01;

namespace BDSA2017.Assignment01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Calculator cal = new Calculator();
            int n = 0;
           
                if (args[0].Equals("Leap"))
                {
                    String x = args[1];
                    bool isNumber = int.TryParse(x, out n);
                    if (isNumber == true)
                    {
                    Console.WriteLine("we made it");
                    Console.ReadLine();
                    }
                } else 
                    
                    Console.WriteLine(Calculator.IsLeapYear(n));
                    Console.ReadLine();
                 
        }
            
           
        }
    }