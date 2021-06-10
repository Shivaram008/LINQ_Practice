using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Practice
{
    class LINQ_Concat
    {
        static void Main(string[] args)
        {
            List<int> a = new List<int>() { 1, 2, 3, 4, 5 };
            List<int> b = new List<int>() { 6, 7, 8, 9, 10 };
            var res = a.Concat(b);
            foreach(var i in res)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();
            var c = new List<string>() { "Siva", "Ram", "Prasad" };
            var d = new List<string>() { "Bhavana", "Divya" };
            //var res1 = a.Concat(c);

            foreach(var i in c.Concat(d))
            {
                Console.WriteLine(i);
            }
        }
    }
}
