using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public interface ITestPaper
    {
        string SubjectName { get; set; }

        string TestPaperName { get; set; }

        List<IQuestion> Questions { get; set; }
    }
}
