using System;
using System.Linq;
namespace demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int waitingPeople = int.Parse(Console.ReadLine());
            int[] wagons = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int wagonLimit = 4;

            for (int i = 0; i < wagons.Length; i++)
            {
                for (int j = wagons[i]; j < wagonLimit; j++)
                {
                    wagons[i]++;
                    waitingPeople--;
                    if (waitingPeople == 0)
                    {
                        if (wagons.Sum() < wagons.Length * wagonLimit)
                        {
                            Console.WriteLine("The lift has empty spots!");
                        }
                        Console.WriteLine(String.Join(' ', wagons));
                        
                        return;
                    }
                }
            }
            Console.WriteLine($"There isn't enough space! {waitingPeople} people in a queue!");
            Console.WriteLine(String.Join(' ', wagons));
        }
    }
}
    