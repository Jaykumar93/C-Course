using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public interface IStudent
    {
        int RollNo { get; set; }

        string StudentName { get; set; }

        List<ITestPaper> TestPapers { get; set; }
    }
}
