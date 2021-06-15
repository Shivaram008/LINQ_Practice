using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Practice
{
    class LINQ_LetAndInto
    {
        static void Main(string[] args)
        {
            IList<Student> studentList = new List<Student>() {
                new Student() { Id = 1, Name = "John", Age = 18 } ,
                new Student() { Id = 2, Name = "Steve",  Age = 21 } ,
                new Student() { Id = 3, Name = "Bill",  Age = 18 } ,
                new Student() { Id = 4, Name = "Ram" , Age = 20 } ,
                new Student() { Id = 5, Name = "Ron" , Age = 21 }
            };

            var lowercaseStudentNames = from s in studentList
                                        where s.Name.ToLower().StartsWith("r")
                                        select s.Name.ToLower();

            var lowercaseStudentNames1 = from s in studentList                              //Let Keyword
                                        let lowercaseStudentName = s.Name.ToLower()
                                        where lowercaseStudentName.StartsWith("r")
                                        select lowercaseStudentName;

            foreach (var name in lowercaseStudentNames1)
                Console.WriteLine(name);

            var teenAgerStudents = from s in studentList                                    //Into Keyword
                                   where s.Age > 12 && s.Age < 20
                                   select s into teenStudents select teenStudents;

            foreach(var i in teenAgerStudents)
            {
                Console.WriteLine(i.Name);
            }
        }
    }
}
