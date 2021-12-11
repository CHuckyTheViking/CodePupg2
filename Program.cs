using Design_Patterns_Assignment;
using Design_Patterns_Assignment.Decorator;
using Design_Patterns_Assignment.Decorator.Classes;
using Design_Patterns_Assignment.Observer;
using Design_Patterns_Assignment.Repository;
using Design_Patterns_Assignment.Strategy;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Strategy strategy = new Strategy();
            Repository repository = new Repository();
            Observer observer = new Observer();
            Decorator decorator = new Decorator();
            
           //decorator.Run();
            //repository.Run();
            //strategy.Run();
            observer.Run();
        }     
    }
}
