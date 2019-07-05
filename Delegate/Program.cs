using System;

namespace Delegate
{
    class Program
    {
        delegate void SayGreeting(string name);

        public static void SayGoodby(string name)
        {
            Console.WriteLine(string.Format("Goodby {0}", name));
        }
        static void Main(string[] args)
        {
            SayGreeting sayGreeting = delegate (string name)
            {
                Console.WriteLine(string.Format("Hello {0}", name));
            };

            Console.WriteLine("What's your name?");
            string input = Console.ReadLine();
            sayGreeting(input);
            sayGreeting = new SayGreeting(SayGoodby);
            sayGreeting(input);
        }
    }
}
