using System;
namespace Task1.Exception
{
    public class NotExsistExseption:SystemException
    {
        public NotExsistExseption(string message):base(message)
        {

        }
    }
}
