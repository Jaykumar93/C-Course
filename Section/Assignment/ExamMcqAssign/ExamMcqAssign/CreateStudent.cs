using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1.Classes;
namespace ExamMcqAssign
{
    public static class CreateStudent
    {
        public static IStudent StudentInfo()
        {
            IStudent student = new Student();
            Console.WriteLine("Enter Students Details:\n");

            Console.WriteLine("Enter ROll No:  ");
            student.RollNo = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Student Name:  ");
            student.StudentName = Console.ReadLine();

            student.TestPapers = new List<ITestPaper>();

            return student ;
        }
    }
}
