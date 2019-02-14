using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueExample
{
    class Message
    {
        private string messageText;
        public Message(string str)
        {
            messageText = str;
        }
        public override string ToString()
        {
            return messageText;
        }
    }

    class Buffer
    {
        private Queue messageBuffer;
        public void SendMessage(Message msg)
        {
            messageBuffer.Enqueue(msg);
        }
        public void ReceiveMessage()
        {
            Message message = (Message)messageBuffer.Dequeue();
            Console.WriteLine(message.ToString());
        }
        public Buffer()
        {
            messageBuffer = new Queue();
        }
    }
    class Messenger
    {
        static void Main(string[] args)
        {
            Buffer objBuffer = new Buffer();
            objBuffer.SendMessage(new Message("One"));
            objBuffer.SendMessage(new Message("Two"));
            objBuffer.ReceiveMessage();
            objBuffer.SendMessage(new Message("Three"));
            objBuffer.ReceiveMessage();
            objBuffer.SendMessage(new Message("Four"));
            objBuffer.ReceiveMessage();
            objBuffer.ReceiveMessage();

            Console.ReadKey();
        }
    }
}
