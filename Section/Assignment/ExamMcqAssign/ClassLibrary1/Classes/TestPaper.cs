using ClassLibrary1;

namespace ClassLibrary1.Classes
{
    public class TestPaper : ITestPaper
    {
        public string SubjectName { get; set; }
        public string TestPaperName { get; set; }
        public List<IQuestion> Questions { get ; set; }
       
        
        
    }
}
