using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ClassLibrary1.Classes
{
    public class Student : IStudent
    {
        public int RollNo { get; set; }
        public string StudentName { get; set; }
        public List<ITestPaper> TestPapers { get; set; }
    }
}
