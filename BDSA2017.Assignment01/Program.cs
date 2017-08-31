using System;

namespace BDSA2017.Assignment01
{
    public class Program
    {
        Calculator cal = new Calculator();
        
        public static void CheckLeapYear(string args1, string args2)
        {
            int n = 0;
            if (args1.ToLower().Equals("leap"))
            {
                String x = args2;
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

        public static void CheckPowerOf(string args1, string args2, string args3)
        {
            int k = 0;
            int n = 0;
            if (args2.ToLower().Equals("powerof"))
            {
                String x = args1;
                String a = args3;
                bool isNumber = int.TryParse(x, out n);
                bool isNumber2 = int.TryParse(a, out k);
                if (isNumber == true && isNumber2 == true)
                {
                    Console.WriteLine(Calculator.IsPowerOf(n, k));

                }
                else
                {
                    Console.WriteLine("Please give numbers as the first and third argument");

                }
            }
            else
            {
                Console.WriteLine("Please write powerof as the second argument");

            }
        }


        public static void Main(string[] args)
        {
          
            if(args == null)
            {
                Console.WriteLine("Please give valid arguments");
            } else
            if (args.Length == 2)
            {
                CheckLeapYear(args[0], args[1]);
            }
            else if (args.Length == 3)
            {
                CheckPowerOf(args[0], args[1], args[2]);
            }
            else
            {
                Console.WriteLine("Please give valid arguments");
                
            }
        }
            
           
        }
    }