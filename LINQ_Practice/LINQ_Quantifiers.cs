using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Practice
{
    class StudentComparer : IEqualityComparer<Student>
    {
        public bool Equals(Student x,Student y)
        {
            if (x.Id == y.Id && x.Name == y.Name)
                return true;
            return false;
        }

        public int GetHashCode(Student obj)
        {
            return obj.GetHashCode();
        }
    }
    class LINQ_Quantifiers
    {
        static void Main(string[] args)
        {
            String[] s = new string[] { "Siva", "Rama", "Prasad", "Divya", "Bhavana", "Sri", "Shanmukhi", "Padma" };

            Console.WriteLine(s.All(k=>k.Length>3));
            Console.WriteLine(s.Any(k=>k.Length>3));
            Console.WriteLine(s.Contains("Ram"));
            Console.WriteLine(s.Contains("Sri"));

            List<Student> l1 = new List<Student>() {
                    new Student(){Id=101,Name="Ram",Age=25},
                    new Student(){Id=132,Name="Prasad",Age=23},
                    new Student(){Id=101,Name="Divya",Age=20},
                    new Student(){Id=165,Name="Bhavana",Age=18},
                    new Student(){Id=123,Name="Siva",Age=21}
            };

            Console.WriteLine("All Age > 20 :"+l1.All(k=>k.Age>20));         //Returns False as we contain age=18.
            Console.WriteLine("Any Age > 24 :"+l1.Any(k=>k.Age>24));         //Returns true as we contain age=25.
            Student std = new Student() { Id = 101, Name = "Ram" };
            Console.WriteLine("Contains student whose name = Ram :"+l1.Contains(std,new StudentComparer()));
        }
    }
}
