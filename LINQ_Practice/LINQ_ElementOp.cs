using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Practice
{
    class LINQ_ElementOp
    {
        static void Main(string[] args)
        {
            var a = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10,10 };
            Console.WriteLine("Element at index 1 :"+a.ElementAt(1));
            
            try
            {
                Console.WriteLine(a.ElementAt(11));
            }
            catch (Exception)
            {
                Console.WriteLine("Trying to print element at index 11 : Index out of Range Error");
            }

            Console.WriteLine("ElementAtOrDefault at index 11 :"+a.ElementAtOrDefault(11));            //prints 0(Default int value)

            Console.WriteLine("First number in sequence > 4 :"+a.First(k=>k>4));                     //prints 5(First occurance)
            Console.WriteLine("First number in sequence / 2 :"+a.First(k=>k%2==0));

            Console.WriteLine("FirstOrDefaut :"+a.FirstOrDefault(k=>k>10));

            Console.WriteLine("First index of 10 :"+a.IndexOf(10));

            Console.WriteLine("Last :"+a.Last(k=>k<10));
            Console.WriteLine("LastOrDefault :"+a.LastOrDefault(k=>k>10));

            Console.WriteLine("Last index of 10 :"+a.LastIndexOf(10));

            var b = new List<int>() { 1, 2, 3, 4 };
            try
            {
                Console.WriteLine(b.Single(k => k % 2 == 1));
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            
            Console.WriteLine(b.SingleOrDefault(k=>k>3));
        }
    }
}
