using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
namespace ClassLibrary1.Classes
{
    class Question:IQuestion
    {
        string QuestionText;

        List<IOption> Options;

        char CorrectAnswerLetter;

        char OptionSelectedByStudent;

        int MarksSecured;
    }
}
