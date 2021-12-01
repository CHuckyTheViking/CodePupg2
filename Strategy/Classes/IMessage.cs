﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Strategy.Classes
{
    interface IMessage
    {
        void SendMessage(string message, string receiver);
    }
}
