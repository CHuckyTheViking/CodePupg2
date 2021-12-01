using Design_Patterns_Assignment.Decorator.Classes.DecorationClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Decorator.Classes
{
    class TextDecorator : IText
    {
        private IText Text;
        public string FirstHtml;
        public string LastHtml;

        public TextDecorator(IText text)
        {
            Text = text;
        }

        public string GetFirstHtml()
        {
            return Text.GetFirstHtml() + FirstHtml;
        }

        public string GetLastHtml()
        {
            return Text.GetLastHtml() + LastHtml;
        }

        public string GetText()
        {
            return Text.GetText();
        }

        public void SetTags(string tags)
        {
            var tagArray = tags.Split(' ');
            foreach (var tag in tagArray)
            {
                if (tag == "Bold")
                    Text = new Bold(Text);
                if (tag == "Deleted")
                    Text = new Deleted(Text);
                if (tag == "Emphasized")
                    Text = new Emphasized(Text);
                if (tag == "Important")
                    Text = new Important(Text);
                if (tag == "Inserted")
                    Text = new Inserted(Text);
                if (tag == "Italic")
                    Text = new Italic(Text);
                if (tag == "Marked")
                    Text = new Marked(Text);
                if (tag == "Smaller")
                    Text = new Smaller(Text);
                if (tag == "Subscript")
                    Text = new Subscript(Text);
                if (tag == "Superscript")
                    Text = new Superscript(Text);

            }
        }

    }
}
