using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamMcqAssign
{
    public static class TakeTest
    {
        public static void TakeTestPaper(ITestPaper paper)
        {
            if (paper == null)
            {
                Console.WriteLine("There is no question paper for the student");
            }
            else
            {
                foreach (IQuestion question in paper.Questions)
                {
                    Console.WriteLine(question.QuestionText);
                    foreach (IOption option in question.Options)
                    {
                        Console.WriteLine(option.OptionLetter + ") " + option.OptionText);
                    }
                    Console.WriteLine("\n Enter your Ans (Option):  ");
                    question.OptionSelectedByStudent = Console.ReadKey().KeyChar;
                }
            }
        }

        static int MarksCalculation(ITestPaper paper)
        {
            int marks =0;
            foreach(IQuestion question in paper.Questions)
            {
                if(question.CorrectAnswerLetter.Equals(question.OptionSelectedByStudent))
                {
                    marks++;
                }
            }

            return marks;

        }
    }
}
