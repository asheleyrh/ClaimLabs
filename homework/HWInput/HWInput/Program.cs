using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWInput
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(" Enter your investment amount, monthly interest rate, and number of years for simple interest");
            //double years = Convert.ToDouble(Console.ReadLine());
            //double interest = Convert.ToDouble(Console.ReadLine());
            //double investment = Convert.ToDouble(Console.ReadLine());

            //double investment = a;



            //Console.WriteLine("your simple interest=" + investment(1 + years * interest));


            int year;

            double princamt, rate, interest, total_amt;

            Console.Write("Enter The Loan Amount : ");
            princamt = Convert.ToDouble(Console.ReadLine());


            Console.Write("Enter The Number of Years : ");
            year = Convert.ToInt16(Console.ReadLine());


            Console.Write("Enter the Rate Of Interest : ");
            rate = Convert.ToDouble(Console.ReadLine());
            interest = princamt * year * rate / 100;
            total_amt = princamt + interest;

            Console.WriteLine("Total Amount : {0}", total_amt);
            

            Console.ReadKey();
        }
    }
}
