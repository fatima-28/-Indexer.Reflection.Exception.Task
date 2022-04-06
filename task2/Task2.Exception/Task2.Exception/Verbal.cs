using System;
namespace Task2.Exception
{
    public class Verbal:Lesson
    {
        public int LectureHours;

        public Verbal(string name,int totalhour, int lecturehours):base(name, totalhour)
        {
            LectureHours = lecturehours;
        }
        public void TimeFixer()
        {
            int fixer = 0;
            if (LectureHours <= TotalHour)
            {
                
                Console.WriteLine($"Total Lecture hour time:{LectureHours} hour");
            }
            else
            {
                fixer = LectureHours - TotalHour;
                fixer = LectureHours - fixer;
                throw new TimeException($"Lecture hour must be less than {fixer}, or equal to {fixer}");
            }
        }
    }
}
