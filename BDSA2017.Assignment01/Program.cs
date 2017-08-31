using System;

namespace BDSA2017.Assignment01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Calculator cal = new Calculator();
            int n = 0;
            int k = 0;
            if(args == null)
            {
                Console.WriteLine("Please give valid arguments");
            } else
            if (args.Length == 2)
            {
                if (args[0].ToLower().Equals("leap"))
                {
                    String x = args[1];
                    bool isNumber = int.TryParse(x, out n);
                    if (isNumber == true)
                    {
                        Console.WriteLine(Calculator.IsLeapYear(n));
                        
                    }
                    else
                    {
                        Console.WriteLine("Please write a valid year number");
                       
                    }

                }
                else
                {

                    Console.WriteLine("Please start your call with leap, followed by a year");
                 

                }
            }
            else if (args.Length == 3)
            {
                if (args[1].ToLower().Equals("powerof"))
                {
                    String x = args[0];
                    String a = args[2];
                    bool isNumber = int.TryParse(x, out n);
                    bool isNumber2 = int.TryParse(a, out k);
                    if (isNumber == true && isNumber2 == true)
                    {
                        Console.WriteLine(Calculator.IsPowerOf(n,k));
                 
                    } else {
                        Console.WriteLine("Please give numbers as the first and third argument");
                        
                    }
                } else
                {
                    Console.WriteLine("Please write powerof as the second argument");
                    
                }
            }
            else
            {
                Console.WriteLine("Please give valid arguments");
                
            }
        }
            
           
        }
    }