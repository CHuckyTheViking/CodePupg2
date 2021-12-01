using Design_Patterns_Assignment;
using Design_Patterns_Assignment.Decorator.Classes;
using System;

namespace Design_Patterns_Assignment.Decorator
{
    internal class Decorator
    {

        internal void Run()
        {
        // Refactor this code so that it uses the Decorator Pattern



            Restart:
            Console.Clear();
            Console.WriteLine("Decorator");
            Console.WriteLine("Please enter the text.");

            var Text = new Text();
            TextDecorator textDecorator = new TextDecorator(Text);

        

            Text.TextString = Console.ReadLine();

            Continue:
            Console.Clear();

            Console.WriteLine();
            Console.WriteLine("Bold");
            Console.WriteLine("Deleted");
            Console.WriteLine("Emphasized");
            Console.WriteLine("Important");
            Console.WriteLine("Inserted");
            Console.WriteLine("Italic");
            Console.WriteLine("Marked");
            Console.WriteLine("Smaller");
            Console.WriteLine("Subscript");
            Console.WriteLine("Superscript");
            Console.WriteLine();
            Console.WriteLine("Type the tags you want separated by space");

            string tags = Console.ReadLine();   
            textDecorator.SetTags(tags);

            Console.WriteLine($"{textDecorator.GetFirstHtml()}{textDecorator.GetText()}{textDecorator.GetLastHtml()}");

            Console.WriteLine("Add more tags?" +
                              "\n y/n");
            var choice = Console.ReadKey();
            if (choice.KeyChar.ToString() == "y")
                goto Continue;
            else
                goto Restart;





        }
    }
}