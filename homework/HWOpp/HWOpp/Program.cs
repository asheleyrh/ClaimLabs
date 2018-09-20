using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWOpp
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            int b = 9; 
            
            Console.WriteLine("What operator would you like to use for 3 and 9");
        

            //char choice = (char)Console.Read();
            string choice = Console.ReadLine();
            Console.ReadLine();

            switch (choice)
            {
                case "+":
                    Console.WriteLine("Your total " + (a + b));
                       break;
                case "-":
                    Console.WriteLine("Your total " + (a - b));
                        break;
                case "*":
                    Console.WriteLine("Your total " + (a * b));
                    break;
                case "/":
                    Console.WriteLine("Your total " + (a / b));
                    break;
                
            }
            Console.WriteLine("your total is {0}", choice);
            Console.ReadLine();


        }
    }
}
