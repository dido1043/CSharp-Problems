using System;
using System.Collections.Generic;

namespace adMsg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RandomMsg phrase = new RandomMsg(new List<string>() { "Excellent product.", "Such a great product.", "I always use that product.",
                "Best product of its category.", "Exceptional product.", "I can’t live without this product." });

            RandomMsg evnt = new RandomMsg(new List<string>() { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" });

            RandomMsg author = new RandomMsg(new List<string>() {"Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" });

            RandomMsg city = new RandomMsg(new List<string>() { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" });

            Console.WriteLine($"{phrase.getRandom()} {evnt.getRandom()} {author.getRandom()} – {city.getRandom()}");
        }
    }

    class RandomMsg
    {
        public RandomMsg(List<string> msg)
        {
            Msg = msg;
        }

        public List<string> Msg { get; set; }

        public string getRandom()
        {
            Random random = new Random();
            return Msg[random.Next(Msg.Count)];
        }
    }
}
