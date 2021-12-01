using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Observer.Classes
{
    class EMail : IEMail
    {
        public int Id { get; set; }
        public string From { get; set; }
        public string Message { get; set; }
    }
}
