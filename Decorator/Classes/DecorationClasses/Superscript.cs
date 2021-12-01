using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Decorator.Classes.DecorationClasses
{
    class Superscript : TextDecorator
    {
        public Superscript(IText text) : base(text)
        {

            FirstHtml = "<sup>";
            LastHtml = "</sup>";
        }
    }
}
