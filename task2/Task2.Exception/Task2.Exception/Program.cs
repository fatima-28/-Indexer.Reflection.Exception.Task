using System;

namespace Task2.Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            Numerical lesson1 = new Numerical("Math", 20, 8);
            Numerical lesson2 = new Numerical("Chemstry", 10, 15);
            Verbal lesson3 = new Verbal("Literature", 30, 20);
            Verbal lesson4 = new Verbal("French language", 20, 50);
            lesson1.TimeCalculator();
            lesson2.TimeCalculator();
            lesson3.TimeFixer();
            lesson4.TimeFixer();



        }
    }
}
