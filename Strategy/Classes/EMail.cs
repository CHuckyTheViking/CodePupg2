using System;


namespace Design_Patterns_Assignment.Strategy.Classes
{


    class EMail : IMessage
    {
        public void SendMessage(string message, string receiver)
        {
            Console.WriteLine("");
            Console.WriteLine($"Sending: \n{message} \nTo: {receiver} \nas Email");

            Console.WriteLine("\n Press any key");
        }


    }
}
