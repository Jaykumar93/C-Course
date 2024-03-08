using System;
using College;

namespace OneToOneExample
{
    class Program
    {
        static void Main()
        {
            Student student = new Student();
            student.RollNo = 1;
            student.StudentName = "jay";
            student.Email = "2dfjklfj@gmail.com";

            Branch br = new Branch();

            br.BranchName = "Information Technology";
            br.NoOfSemesters = 7;
            

            //one to one relationship 
            student.branch = br;

            Console.WriteLine(student.RollNo);
            Console.WriteLine(student.StudentName);
            Console.WriteLine(student.Email);
            Console.WriteLine(student.branch.BranchName);
            Console.WriteLine(student.branch.NoOfSemesters);

            Console.ReadKey();
        }
    }
}
