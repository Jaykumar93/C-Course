
using ClassLibrary1;

namespace ClassLibrary1.Classes
{
    public class Question : IQuestion
    {
        public string QuestionText { get; set; }
        public List<IOption> Options { get ; set; }
        public char CorrectAnswerLetter { get; set ; }
        public char OptionSelectedByStudent { get ; set ; }
        public int MarksSecured { get; set; }
    }
}
