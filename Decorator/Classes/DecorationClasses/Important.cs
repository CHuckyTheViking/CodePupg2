using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Decorator.Classes.DecorationClasses
{
    class Important : TextDecorator
    {
        public Important(IText text) : base(text)
        {

            FirstHtml = "<strong>";
            LastHtml = "</strong>";
        }
    }
}
