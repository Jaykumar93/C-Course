

namespace ClassLibrary1
using ClassLibrary1;
{
    public interface IQuestion
    {
        string QuestionText { get; set; }

        List<ITestPaper> Options { get; set; }

        char CorrectAnswerLetter { get; set; }

        char OptionSelectedByStudent { get; set; }

        int MarksSecured { get; set; }
    }
}
