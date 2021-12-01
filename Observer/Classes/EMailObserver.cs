using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Observer.Classes
{
    class EMailObserver : IObserver<EMail>
    {
        public void Update(EMail email)
        {
            if (email != null)
            {
                Console.WriteLine($"You have a new Email" +
                                 $"\nFrom: {email.From}" +
                                 $"\nMessage: {email.Message}");
            }
        }
    }
}
