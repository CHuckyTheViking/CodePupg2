using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Decorator.Classes
{

    class Text : IText
    {
        public string FirstHtml { get; set; }
        public string TextString { get; set; }
        public string LastHtml { get; set; }

        public string GetFirstHtml()
        {
            return FirstHtml;
        }

        public string GetLastHtml()
        {
            return LastHtml;
        }

        public string GetText()
        {
            return TextString;
        }
    }
}
