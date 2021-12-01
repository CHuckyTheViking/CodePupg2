using Design_Patterns_Assignment;
using Design_Patterns_Assignment.Repository.Classes;
using System;

namespace Design_Patterns_Assignment.Repository
{
    internal class Repository
    {
        internal void Run()
        {
            // Refactor this code so that it uses the Repository Pattern
            DatabaseService dbService = new DatabaseService();
            dbService.init();
            Start:

            Console.WriteLine("Repository");

            Console.WriteLine("1: Show data" +
                            "\n2: Show Customers" +
                            "\n3: Show Animals" +
                            "\n4: Search for Customer" +
                            "\n5: Search for Animal" +
                            "\n6: Add Customer" +
                            "\n7: Add Animal");

            var choice = int.Parse(Console.ReadKey().KeyChar.ToString());
            Console.Clear();

            if (choice == 1)
            {
                var data = dbService.GetAllData();

                foreach (var item in data)
                {
                    Console.WriteLine("------------");
                    Console.WriteLine(item.Id);
                    Console.WriteLine(item.Name);
                    Console.WriteLine(item.Type);
                }
                Console.ReadKey();
                Console.Clear();
            }
            if (choice == 2)
            {
                var data = dbService.GetCustomers();
                foreach (var item in data)
                {
                    Console.WriteLine("------Customer------");
                    Console.WriteLine(item.Id);
                    Console.WriteLine(item.Name);
                    Console.WriteLine(item.Type);
                }
                Console.ReadKey();
                Console.Clear();
            }
            if (choice == 3)
            {
                var data = dbService.GetAnimals();
                foreach (var item in data)
                {
                    Console.WriteLine("------Animal------");
                    Console.WriteLine(item.Id);
                    Console.WriteLine(item.Name);
                    Console.WriteLine(item.Type);
                }
                Console.ReadKey();
                Console.Clear();
            }
            if (choice == 4)
            {
                Console.WriteLine("Please enter the ID to search for");
                var id = int.Parse(Console.ReadLine().ToString());
                Console.Clear();
                var data = dbService.GetCustomerById(id);

                Console.WriteLine("------Customer------");
                Console.WriteLine(data.Id);
                Console.WriteLine(data.Name);
                Console.WriteLine(data.Type);

                Console.ReadKey();
                Console.Clear();
            }
            if (choice == 5)
            {
                Console.WriteLine("Please enter the ID to search for");
                var id = int.Parse(Console.ReadLine().ToString());
                Console.Clear();
                var data = dbService.GetAnimalById(id);

                Console.WriteLine("------Animal------");
                Console.WriteLine(data.Id);
                Console.WriteLine(data.Name);
                Console.WriteLine(data.Type);

                Console.ReadKey();
                Console.Clear();
            }
            if (choice == 6)
            {
               
                Customer customer = new Customer();
                Console.WriteLine("Please enter the full name of the customer");
                customer.Name = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Please enter the Type of customer" +
                                  "\n1: Regular | 2: VIP ");
                var typeChoice = int.Parse(Console.ReadKey().KeyChar.ToString());
                if (typeChoice == 1)
                    customer.Type = "Regular";
                else
                    customer.Type = "VIP";
                Console.Clear();
                // Här kollar man igentligen senast id't i funktionen när man lägger till eller dylikt. Men gör en random
                Random rnd = new Random();
                customer.Id = rnd.Next(3, 100);

                dbService.AddCustomer(customer);
            }
            if (choice == 7)
            {

                Animal animal = new Animal();
                Console.WriteLine("Please enter the name of the animal");
                animal.Name = Console.ReadLine();
                Console.Clear();

                Console.WriteLine("Please enter the Type of animal");
                animal.Type = Console.ReadLine();
                Console.Clear();

                // Här kollar man igentligen senast id't i funktionen när man lägger till eller dylikt. Men gör en random
                Random rnd = new Random();
                animal.Id = rnd.Next(3, 100);

                dbService.AddAnimal(animal);
            }
            goto Start;
        }
    }
}