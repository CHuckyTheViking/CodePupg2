using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Repository.Classes
{

    class Customer : IDataModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }

    }
}
