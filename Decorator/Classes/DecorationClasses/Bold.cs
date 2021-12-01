using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Decorator.Classes.DecorationClasses
{
    class Bold : TextDecorator
    {
        public Bold(IText text) : base(text)
        {
            FirstHtml = "<b>";
            LastHtml = "</b>";
        }

    }
}
