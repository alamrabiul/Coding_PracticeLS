using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackExample
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
        private Stack messageBuffer;
        public void SendMessage(Message msg)
        {
            messageBuffer.Push(msg);
        }
        public void ReceiveMessage()
        {
            Message message = (Message)messageBuffer.Pop();
            Console.WriteLine(message.ToString());

        }
        public Buffer()
        {
            messageBuffer = new Stack();
        }
    }
    class Messenger
    {
        static void Main(string[] args)
        {
            Buffer buffer = new Buffer();
            buffer.SendMessage(new Message("One"));
            buffer.SendMessage(new Message("Two"));
            buffer.ReceiveMessage();
            buffer.SendMessage(new Message("Three"));
            buffer.ReceiveMessage();
            buffer.SendMessage(new Message("Four"));
            buffer.ReceiveMessage();
            buffer.ReceiveMessage();

            Console.ReadKey();
        }
    }
}
