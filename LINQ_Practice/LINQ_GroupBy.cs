using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Practice
{
    class LINQ_GroupBy
    {
        static void Main(string[] args)
        {
            List<Student> l1 = new List<Student>() {
                    new Student(){Id=101,Name="Ram",Age=18},
                    new Student(){Id=132,Name="Prasad",Age=20},
                    new Student(){Id=101,Name="Divya",Age=20},
                    new Student(){Id=165,Name="Bhavana",Age=18},
                    new Student(){Id=123,Name="Siva",Age=21}
            };

            var groupBy = from s in l1 group s by s.Age;            //Query Syntax

            var groupBy1 = l1.GroupBy(s => s.Age);                  //Method Syntax

            foreach(var i in groupBy)
            {
                Console.WriteLine("AgeGroup :"+i.Key);
                foreach(var j in i)
                {
                    Console.WriteLine(j.Name);
                }
            }

            Console.WriteLine();

            foreach (var i in groupBy1)
            {
                Console.WriteLine("AgeGroup :" + i.Key);
                foreach (var j in i)
                {
                    Console.WriteLine(j.Name);
                }
            }

            Console.WriteLine();
            var ToLookUp = l1.ToLookup(s => s.Age);
            foreach (var i in ToLookUp)
            {
                Console.WriteLine("AgeGroup :" + i.Key);
                foreach (var j in i)
                {
                    Console.WriteLine(j.Name);
                }
            }
        }
    }
}
