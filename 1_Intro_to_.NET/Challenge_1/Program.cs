using System;

namespace Challenge_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var name = TryAnswer();

            Console.WriteLine("How old are you?");
            var age = TryAnswer();

            Console.WriteLine("What month were you born in?");
            var month = TryAnswer();

            Console.WriteLine("Your name is: {0}", name);
            Console.WriteLine("Your age is: {0}", age);
            Console.WriteLine("You were born in: {0}", month);

            if (month.ToLower() == "march")
            {
                Console.WriteLine("You are an Aries");
            }
            else if (month.ToLower() == "april")
            {
                Console.Write("you are an Taurus");
            }
            else if (month.ToLower() == "may")
            {
                Console.WriteLine("You are an Gemini");
            }
        }

        static string TryAnswer()
        {
            var question = Console.ReadLine();
            if (question == "")
            {
                Console.WriteLine("You didn't type anything, please try again:");
                return Console.ReadLine();
            }
            return question;
        }
    }
}
