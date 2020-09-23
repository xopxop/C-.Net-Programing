using System;

namespace SchoolTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentGrade = new int[] {88 , 77, 42, 21, 77, 88, 99, 100, 24, 68};

            foreach(var item in studentGrade)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}
