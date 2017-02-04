using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqSample
{
    /// <summary>
    /// Linq works on Only those implement IEnumerable<T> or IQueryable<T>
    /// </summary>
    class Program
    {
        private static List<Student> students;
        static void Main(string[] args)
        {
            Initialize();

            // query all the data
            // format: from element in datasource select element
            var queryAll = from stu in students select stu;
            Console.WriteLine("Query All:");
            foreach (var stu in queryAll)
                Display(stu);

            // query female
            var queryFemale = from stu in students where !stu.Male select stu;
            Console.WriteLine("Query Female:");
            foreach (var stu in queryFemale)
                Display(stu);

            // query and orderby
            var queryAndOrderby = from stu in students where stu.Age < 25 orderby stu.Name, stu.Age select stu;
            Console.WriteLine("Query and Orderby: ");
            foreach (var stu in queryAndOrderby)
                Display(stu);

            Console.Read();
        }

        private static void Display(Student stu)
        {
            Console.WriteLine(stu.ToString());
        }

        private static void Initialize()
        {
            students = new List<Student>();

            Score score1_1 = new Score { Subject = "English", Grade = 85 };
            Score score1_2 = new Score { Subject = "Meth", Grade = 76 };
            Score score1_3 = new Score { Subject = "Computer", Grade = 92 };
            Student stu1 = new Student
            {
                Name = "Owen",
                Male = true,
                Age = 23,
                Scores = new List<Score> { score1_1, score1_2, score1_3 }
            };

            Score score2_1 = new Score { Subject = "English", Grade = 84 };
            Score score2_2 = new Score { Subject = "Meth", Grade = 96 };
            Score score2_3 = new Score { Subject = "Computer", Grade = 92 };
            Student stu2 = new Student
            {
                Name = "Oliver",
                Male = true,
                Age = 21,
                Scores = new List<Score> { score2_1, score2_2, score2_3 }
            };

            Score score3_1 = new Score { Subject = "English", Grade = 90 };
            Score score3_2 = new Score { Subject = "Meth", Grade = 76 };
            Score score3_3 = new Score { Subject = "Computer", Grade = 92 };
            Student stu3 = new Student
            {
                Name = "Lynn",
                Male = false,
                Age = 22,
                Scores = new List<Score> { score3_1, score3_2, score3_3 }
            };

            Score score4_1 = new Score { Subject = "English", Grade = 87 };
            Score score4_2 = new Score { Subject = "Meth", Grade = 76 };
            Score score4_3 = new Score { Subject = "Computer", Grade = 92 };
            Student stu4 = new Student
            {
                Name = "Alice",
                Male = false,
                Age = 25,
                Scores = new List<Score> { score4_1, score4_2, score4_3 }
            };

            students.Add(stu1);
            students.Add(stu2);
            students.Add(stu3);
            students.Add(stu4);
        }
    }
}
