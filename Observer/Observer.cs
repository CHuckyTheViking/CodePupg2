using Design_Patterns_Assignment.Observer.Classes;
using Design_Patterns_Assignment.Observer.Simulator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Design_Patterns_Assignment.Observer
{
    class Observer
    {
        internal void Run()
        {
            // Refactor this code so that it uses the Observer Pattern
            Console.WriteLine("Observer");

            Start:
             var rnd = new Random();
            var aTimer = new Timer(rnd.Next(3000, 6000));
               
            aTimer.Enabled = true;
            aTimer.Elapsed += TimedEmail;
            Console.ReadKey();
            goto Start;


        } 
        private static void TimedEmail(Object source, ElapsedEventArgs e)
        {
            Console.Clear();
            var observer = new ObserverService<EMail>();
            var emailObserver = new EMailObserver();
            var emailSimulator = new EmailSimulator();
            observer.Register(emailObserver);
            emailSimulator.init();

            observer.Subject = emailSimulator.GetRandomEmail();
             
        }
    }
}
