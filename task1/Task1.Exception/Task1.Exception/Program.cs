using System;

namespace Task1.Exception
{
    class Program
    {
        static void Main(string[] args)
        {

            //Program class-ında bir menu olacaq
            //1. Send message by email
            //2. Send message by sms
            //0. Quit

            //İstifadəçi 1 yazıb enter-ə click-ləsə Email ilə mesaj göndərilməlidi.
            //İstifadəçi 2 yazıb enter-ə click-ləsə Sms ilə mesaj göndərilməlidi.
            //İstifadəçi 0 yazıb enter-ə click-ləsə proqram sonlanmalıdı.

            int num = int.Parse(Console.ReadLine());
            if (num == 1)
            {
                EmailSender();
            }
            else if (num==2)
            {
                SmsSender();
            }
            else if(num==0)
            {
                Console.WriteLine("Program Closed");
            }
            else
            {
                throw new NotExsistExseption("This decision is no exsist");
            }


        }

        private static void SmsSender()
        {
            throw new NotImplementedException();
        }

        private static void EmailSender()
        {
            throw new NotImplementedException();
        }
    }
}
