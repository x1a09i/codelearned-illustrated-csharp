using System;
using System.Linq;

namespace FromClauseAndJoinClause
{
    class FromClauseAndJoinClause
    {
        class Student
        {
            public int StID;
            public string LastName;
        }

        class CourseStudent
        {
            public int StID;
            public string CourseName;
        }

        static Student[] students = new[] {
            new Student { StID = 1, LastName = "Carter" },
            new Student { StID = 2, LastName = "McGrady" },
            new Student { StID = 3, LastName = "YaoMing" },
        };

        static CourseStudent[] courses = {
            new CourseStudent { StID = 1, CourseName = "History" },
            new CourseStudent { StID = 2, CourseName = "Philosophy" },
            new CourseStudent { StID = 3, CourseName = "Mathmatics" },
            new CourseStudent { StID = 3, CourseName = "Music" },
            new CourseStudent { StID = 3, CourseName = "History" },
        };

        static void Main(string[] args)
        {
            var query = from s in students
                        join c in courses on s.StID equals c.StID
                        where c.CourseName == "History"
                        select s.LastName;

            var queryJoin = from s in students
                        join c in courses on s.StID equals c.StID
                        select s;

            foreach (var studentName in query)
                Console.WriteLine("Student taking History: {0}", studentName);

            foreach (var student in queryJoin)
                Console.WriteLine("Name: {0}, StID: {1}", student.LastName, student.StID);

            Console.ReadKey();
        }
    }
}
