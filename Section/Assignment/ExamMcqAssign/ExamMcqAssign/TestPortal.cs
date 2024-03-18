using ClassLibrary1;
using ClassLibrary1.Classes;

namespace ExamMcqAssign
{
    public class TestPortal
    {
        static void Main(string[] args)
        {


            int portalChoice = -1;
            Console.WriteLine("+++++++++++++++++++  Welcome to the Exam Portal  +++++++++++++++++++");

            Console.WriteLine("How do you want to login: \n1} Teacher Portal \n2} Student Portal \n0} Exit \n Enter UserChoice (either 1,2 or 0):  ");
            portalChoice = int.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine("+++++++++++++++++++  Welcome to the Exam Portal  +++++++++++++++++++");
                Console.WriteLine("How do you want to login: \n1} Teacher Portal \n2} Student Portal \n0} Exit \n Enter UserChoice (either 1,2 or 0):  ");
                portalChoice = int.Parse(Console.ReadLine());

                if (portalChoice == 1)
                {
                    ITestPaper testPaper = TestPaperQuestion.CreateTestPaper();

                    Console.WriteLine("Enter details for Test Paper 1:");
                    testPaper = TestPaperQuestion.CreateTestPaper();
                }
                else if(portalChoice == 2)
                {
                    Console.WriteLine("Enter student details:");
                    IStudent student = CreateStudent.StudentInfo();

                    Console.WriteLine("Enter your Roll no : " + student.RollNo);
                    Console.WriteLine();
                    Console.WriteLine("Student: " + student.StudentName);
                    Console.WriteLine();

                    //Console.WriteLine("Test Paper 1 - " + testPaper.SubjectName);
                    Random random = new Random();
                    int index = random.Next(0, TestPaperQuestion.testPapers.Count);

                    TakeTest.TakeTestPaper(TestPaperQuestion.testPapers[index]);

                }
                
                Thread.Sleep(5000);
                Console.Clear();    
            }while (portalChoice !=0);

        }
    }
}
