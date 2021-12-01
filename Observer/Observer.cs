using Design_Patterns_Assignment.Observer.Classes;
using Design_Patterns_Assignment.Observer.Simulator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Observer
{
    class Observer
    {
        internal void Run()
        {
            // Refactor this code so that it uses the Observer Pattern
            Console.WriteLine("Observer");
            var observer = new ObserverService<EMail>();
            var emailObserver = new EMailObserver();
            var emailSimulator = new EmailSimulator();
            observer.Register(emailObserver);
            emailSimulator.init();

            Start:
            observer.Subject = emailSimulator.GetRandomEmail();

            Console.ReadKey();
            Console.Clear();
            goto Start;
        }
    }
}
