using System;

namespace Survey
{
    class Data
    {
        public string Name;
        public int Age;
        public string Month;

        public void Display()
        {
            Console.WriteLine("Your name is: {0}", Name);
            Console.WriteLine("Your age is: {0}", Age);
            Console.WriteLine("You were born in: {0}", Month);

            if (Month.ToLower() == "march")
            {
                Console.WriteLine("You are an Aries");
            }
            else if (Month.ToLower() == "april")
            {
                Console.Write("you are an Taurus");
            }
            else if (Month.ToLower() == "may")
            {
                Console.WriteLine("You are an Gemini");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var data = new Data();
            Console.WriteLine("What is your name?");
            data.Name = TryAnswer();

            Console.WriteLine("How old are you?");
            data.Age = int.Parse(TryAnswer());

            Console.WriteLine("What month were you born in?");
            data.Month = TryAnswer();

            data.Display();
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
