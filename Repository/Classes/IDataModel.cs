using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Repository.Classes
{
    interface IDataModel
    {
        int Id { get; set; }
        string Name { get; set; }
        string Type { get; set; }
    }
}
