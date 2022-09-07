using System;
using System.Collections.Generic;
using System.Linq;

namespace movingTarget
{
    internal class Program
    {
        static void Main(string[] args)
        {

        List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "End")
                {
                    break;
                }
                string[] tokens = command.Split();
                string action = tokens[0];
          
                if (action == "Shoot")
                {
                  Shoot(int.Parse(tokens[1]), int.Parse(tokens[2]),  numbers);

                }
                else if (action == "Add")
                {
                    Add(int.Parse(tokens[1]), int.Parse(tokens[2]), numbers);
                }
                else if (action == "Strike")
                {
                  Strike(int.Parse(tokens[1]), int.Parse(tokens[2]), numbers);
                    
                }
            }
            Console.WriteLine(String.Join("|", numbers));

        }
        static void Shoot(int index, int power, List<int> list)
        {
            if (list[index] < power)
            {
                list.RemoveAt(index);
            }
            else
            {
                list[index] -= power;
            }
        }
        static void Add(int index, int value, List<int> list)
        {
            if (index < 0 || index>=list.Count - 1)
            {
                Console.WriteLine("Invalid placement!");

                return;
            }
            list.Insert(index, value);
        }
        static void Strike(int index, int range, List<int> list)
        {

            if (index <= 0 || index > list.Count-1 || index - range < 0 || index + range > list.Count - 1 ) 
            {
                Console.WriteLine("Strike missed!");

                return;
            }
           list.RemoveRange(index-range, range*2+1);
        }
    }
}
