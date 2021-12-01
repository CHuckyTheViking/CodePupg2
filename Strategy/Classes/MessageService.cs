using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Strategy.Classes
{
    class MessageService
    {
        private IMessage MessageType;
        private string Message;
        private string Receiver;

        public void SetMessageType(IMessage messageType)
        {
            MessageType = messageType;
        }

        public void SetMessageText(string message)
        {
            Message = message;
        }

        public void SetReceiver(string receiver)
        {
            Receiver = receiver;
        }

        public void SendMessage()
        {
            MessageType.SendMessage(Message, Receiver);
        }
    }
}
