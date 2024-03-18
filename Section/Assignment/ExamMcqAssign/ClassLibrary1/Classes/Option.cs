using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ClassLibrary1.Classes
{
    public class Option:IOption
    {
        public char OptionLetter { get; set; }
        public string OptionText { get; set; }
        
    }
}
