using ClassLibrary1;
using ClassLibrary1.Classes;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamMcqAssign
{
    public static class TestPaperQuestion
    {
       public  static List<ITestPaper> testPapers = new List<ITestPaper>();
        public static ITestPaper CreateTestPaper()
        {
            ITestPaper testPaper = new TestPaper();

            Console.Write("Enter subject name: ");
            testPaper.SubjectName = Console.ReadLine();

            Console.Write("Enter test paper name: ");
            testPaper.TestPaperName = Console.ReadLine();

            testPaper.Questions = new List<IQuestion>();
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"\nEnter the {i} question of the paper :");
                IQuestion question = CreateQuestion();
                testPaper.Questions.Add(question);  
            }

            testPapers.Add(testPaper);
            Console.WriteLine("!!!!!!!!!!!! Paper created : Going back to Home Page !!!!!!!!!!!!");

            return testPaper;
        }
        static IQuestion CreateQuestion()
        {
            IQuestion question = new Question();

            Console.Write("Enter the question : ");
            question.QuestionText = Console.ReadLine();

            question.Options = new List<IOption>();

            for (char optionletter = 'A'; optionletter <= 'D'; optionletter++)
            {   
                Console.Write(optionletter+"} ");
                String OptionText = Console.ReadLine();

                IOption options = new Option
                {
                    OptionLetter = optionletter,
                    OptionText = OptionText
                };
                question.Options.Add(options);
            }

            Console.Write("Enter correct Option for the above question: ");
            question.CorrectAnswerLetter = char.ToUpper(Console.ReadKey().KeyChar);

            return question;
        }
        
    }
}
