using System;

namespace Challenge_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = "";
            while (input != "secret")
            {
                Console.Write("You passcode is: ");
				input = Console.ReadLine();
				if (input != "secret")
                {
                    Console.WriteLine("You are not authenticated");
                }
            }
			Console.WriteLine("You are authenticated");
        }
    }
}
