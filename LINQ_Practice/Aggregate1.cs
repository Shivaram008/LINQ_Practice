using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Practice
{
    class Aggregate1
    {
        public static int Add(int x, int y)
        {
            return x + y;
        }
        static void Main(string[] args)
        {
            String[] s = new string[] { "Siva","Rama","Prasad","Divya","Bhavana","Sri","Shanmukhi","Padma"};
            Console.WriteLine("Names : "+s.Aggregate((s1,s2)=>s1+" ,"+s2));

            Console.WriteLine("Any Length greater than 3 :"+s.Aggregate(false,(any,val)=>any||val.Length>3));
            Console.WriteLine("All Length greater than 3 :"+s.Aggregate(true,(all,val)=>all&&val.Length>3));

            int[] a = { 1, 2, 3, 4, 5, 6 };
            var sum = a.Aggregate(func: Add);
            Console.WriteLine(sum);

            Console.WriteLine("Average :"+a.Average());
            Console.WriteLine("Sum :"+a.Sum());
            Console.WriteLine("Min :"+a.Min());
            Console.WriteLine("Max :"+a.Max());
            Console.WriteLine("Count :"+a.Count());
        }
    }
}
