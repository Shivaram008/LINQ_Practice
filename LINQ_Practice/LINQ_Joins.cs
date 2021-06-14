using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Practice
{
    class Student1
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int DeptId { get; set; }
    }
    class Dept
    {
        public int DeptId { get; set; }
        public String DeptName { get; set; }
    }
    class LINQ_Joins
    {
        static void Main(string[] args)
        {
            List<Student1> l1 = new List<Student1>() {
                    new Student1(){Id=101,Name="Ram",Age=25,DeptId=1},
                    new Student1(){Id=132,Name="Prasad",Age=23,DeptId=2},
                    new Student1(){Id=101,Name="Divya",Age=20,DeptId=1},
                    new Student1(){Id=165,Name="Bhavana",Age=18,DeptId=3},
                    new Student1(){Id=123,Name="Siva",Age=21,DeptId=2}
            };
            List<Dept> d1 = new List<Dept>()
            {
                new Dept(){DeptId=1,DeptName="IT"},
                new Dept(){DeptId=2,DeptName="CSE"},
                new Dept(){DeptId=3,DeptName="ECE"}
            };

            var result = l1.Join(d1, s => s.DeptId, d => d.DeptId, (s, d) => new { StudentName = s.Name, StudentDept = d.DeptName });
            Console.WriteLine("{0,-15} {1,-15}", "StudentName", "StudentDept");
            foreach (var item in result)
            {
                Console.WriteLine($"{item.StudentName,-15} {item.StudentDept,-15}");
            }
            Console.WriteLine();

            var result1 = from s in l1  join d in d1 on s.DeptId equals d.DeptId  select new { StudentName = s.Name, StudentDept = d.DeptName } ;
            Console.WriteLine("{0,-15} {1,-15}", "StudentName", "StudentDept");
            foreach (var item in result1)
            {
                Console.WriteLine($"{item.StudentName,-15} {item.StudentDept,-15}");
            }

           
        }
    }
}
