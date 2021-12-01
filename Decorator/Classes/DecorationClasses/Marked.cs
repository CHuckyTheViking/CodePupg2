﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Decorator.Classes.DecorationClasses
{
    class Marked : TextDecorator    
    {
        public Marked(IText text) : base(text)
        {

            FirstHtml = "<mark>";
            LastHtml = "</mark>";
        }
    }
}
