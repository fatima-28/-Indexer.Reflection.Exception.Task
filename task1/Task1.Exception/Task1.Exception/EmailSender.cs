using System;
namespace Task1.Exception
{
    public abstract class EmailSender:MessageSender
    {
        public override void SendMessage()
        {
            Console.WriteLine("This email sended ");
        }
    }
}
