using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 3, 7, 9, 2, 14, 6 };

            //length

            Console.WriteLine("length " +numbers.Length );

            //Indexof()
           var index= Array.IndexOf(numbers, 9);
            Console.WriteLine("index of 9:" + index);

            //clear
            Array.Clear(numbers, 0, 2);

            Console.WriteLine("Effect of clear()");
            foreach (var n in numbers)
                Console.WriteLine(n);

            //copy()
            int[] another = new int[3];
            Array.Copy(numbers, another, 3);

            Console.WriteLine("Effect of copy()");
            foreach (var n in another)
                Console.WriteLine(n);

            //sort
            Array.Sort(another);








            //lists
            var numbers = new List<int>() { 1, 2, 3, 4 };
            numbers.add(1);
            numbers.AddRange(new int[3] { 5, 6, 7 });
        }
    }
}
