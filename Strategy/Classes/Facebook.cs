using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Strategy.Classes
{
    class Facebook : IMessage
    {
        public void SendMessage(string message, string receiver)
        {
            Console.WriteLine("");
            Console.WriteLine($"Sending: \n{message} \nTo: {receiver} \nas Facebook message");

            Console.WriteLine("\n Press any key");
        }
    }
}
