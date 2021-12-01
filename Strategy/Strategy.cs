using Design_Patterns_Assignment.Strategy.Classes;
using System;

namespace Design_Patterns_Assignment.Strategy
{
    internal class Strategy
    {

        internal void Run()
        {
            // Refactor this code so that it uses the strategy Pattern

            Start:
            MessageService messageService = new MessageService();

            Console.WriteLine("Strategy");
            Console.WriteLine("1: SMS" +
                           "\n2: Email" +
                           "\n3: Facebook");

            var choice = int.Parse(Console.ReadKey().KeyChar.ToString());
            Console.Clear();

            if (choice == 1)
            {
                messageService.SetMessageType(new Phone());
            }
            if (choice == 2)
            {
                messageService.SetMessageType(new EMail());
            }
            if (choice == 3)
            {
                messageService.SetMessageType(new Facebook());
            }

            Console.WriteLine("\nPlease write the details of the receiver");
            messageService.SetReceiver(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("\nPlease write your message: ");
            messageService.SetMessageText(Console.ReadLine());
            Console.Clear();
            messageService.SendMessage();


            Console.ReadKey();
            Console.Clear();

            goto Start;
                        
        }
    }
}