using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Practice
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
    class LINQ_Ordering
    {
        public static void Display(dynamic l)
        {
            Console.WriteLine("{0,-5} {1,-10} {2,-5}","ID","NAME","AGE");
            foreach(var i in l)
            {
                Console.WriteLine($"{i.Id,-5} {i.Name,-10} {i.Age,-5}");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            List<Student> l1 = new List<Student>() { 
                    new Student(){Id=101,Name="Ram",Age=25},
                    new Student(){Id=132,Name="Prasad",Age=23},
                    new Student(){Id=101,Name="Divya",Age=20},
                    new Student(){Id=165,Name="Bhavana",Age=18},
                    new Student(){Id=123,Name="Siva",Age=21}
            };
            Console.WriteLine("Using SQL Query Syntax:");
            var l2 = from l in l1 orderby l.Id select l;
            Display(l2);
            Console.WriteLine("Using Method Syntax :");
            l2 = l1.OrderBy(x => x.Age);
            Display(l2);

            Console.WriteLine("Orderby Descending Using SQL Query Syntax:");
            l2= from l in l1 orderby l.Id descending select l;
            Display(l2);

            Console.WriteLine("Orderby Descending Using Method Syntax:");
            l2 = l1.OrderByDescending(x => x.Age);
            Display(l2);

            Console.WriteLine("Orderby Thenby Using SQL Query Syntax:");
            l2 = from l in l1 orderby l.Id, l.Name select l;
            Display(l2);

            Console.WriteLine("Orderby Thenby Using Method Syntax:");
            l2 = l1.OrderBy(x => x.Id).ThenBy(y=>y.Name);
            Display(l2);

            Console.WriteLine("Orderby ThenbyDescending Using SQL Query Syntax:");
            l2 = from l in l1 orderby l.Id, l.Name descending select l;
            Display(l2);

            Console.WriteLine("Orderby ThenbyDescending Using Method Syntax:");
            l2 = l1.OrderBy(x => x.Id).ThenByDescending(y => y.Name);
            Display(l2);
        }
    }
}
