using System;
namespace Task2.Exception
{
    public class TimeException:SystemException
    {
        public TimeException(string message):base(message)
        {
        }
    }
}
