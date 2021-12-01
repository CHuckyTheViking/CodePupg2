using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Repository.Classes
{
    class DatabaseService
    {
        // Egentligen samma context här men byggde upp det med 3st olika endast för denna uppgift.
        // Simulerar helt enkelt 2 olika tables i DB'n samt en med all data.
        // Denna variant är ju om man använder Entity Framework.

        // Skulle man behöva använda din "SimulatedDatabase" så hade jag bara kopplat funktionerna nedan till den istället
        // så inga konstigheter med det.

        private List<IDataModel> CustomerContext;
        private List<IDataModel> AnimalContext;
        private List<IDataModel> AllDataContext;

        public DatabaseService(List<IDataModel> customerContext, List<IDataModel> animalContext, List<IDataModel> allDataContext)
        {
            CustomerContext = customerContext;
            AnimalContext = animalContext;
            AllDataContext = allDataContext;
        }

        public DatabaseService()
        {
        }

        public void init()
        {
            CustomerContext = new();
            AnimalContext = new();
            AllDataContext = new();

            CustomerContext.Add(new Customer { Id = 1, Name = "Kalle Karlsson", Type = "Regular"});
            CustomerContext.Add(new Customer { Id = 2, Name = "Per Karlsson", Type = "VIP" });
            AnimalContext.Add(new Animal {Id = 1, Name = "Flash", Type = "Lion" });
            AnimalContext.Add(new Animal { Id = 2, Name = "Blixten", Type = "Doggo" });
        }

        public List<IDataModel> GetAllData()
        {
            foreach (var animal in AnimalContext)
            {
                AllDataContext.Add(animal);
            }
            foreach (var customer in CustomerContext)
            {
                AllDataContext.Add(customer);
            }

            return AllDataContext;
        }

        public List<IDataModel> GetCustomers()
        {
            return CustomerContext;
        }

        public Customer GetCustomerById(int customerId)
        {
            return (Customer)CustomerContext.FirstOrDefault(x => x.Id == customerId);
        }

        public void AddCustomer(Customer customer)
        {
            CustomerContext.Add(customer);
            Console.WriteLine("Customer Added");
        }

        public List<IDataModel> GetAnimals()
        {
            return AnimalContext;
        }

        public Animal GetAnimalById(int animalId)
        {
            return (Animal)AnimalContext.FirstOrDefault(x => x.Id == animalId);
        }

        public void AddAnimal(Animal animal)
        {
            AnimalContext.Add(animal);
            Console.WriteLine("Animal Added");
        }


    }
}
