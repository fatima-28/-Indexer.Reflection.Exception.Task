using System;
namespace Task2.Exception
{
    public class Numerical : Lesson
    {
        public int LabHour;

        public Numerical(string name,int totalhour, int labhour):base(name, totalhour)
        {
            LabHour = labhour;
        }

        public void TimeCalculator()
        {
            if (LabHour<=TotalHour)
            {
                Console.WriteLine($"Total Labhour time:{LabHour} hour");
            }
            else
            {
                throw new TimeException("Lab hours cant be more than total hours");
            }
        }

    }
}
