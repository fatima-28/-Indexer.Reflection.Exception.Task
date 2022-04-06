using System;
namespace Task1.Exception
{
    public abstract class MessageSender
    {
        public virtual  void  SendMessage()
        {
            Console.WriteLine("Text message sended");
        }
    }
}
