

namespace ClassLibrary1
{
    public interface ITestPaper
    {
        string SubjectName { get; set; }

        string TestPaperName { get; set; }

        List<IQuestion> Questions { get; set; }

    }
}
