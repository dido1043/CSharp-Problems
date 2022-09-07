using System;
using System.Collections.Generic;

namespace heroesOfCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary <string, List<int>> dict = new Dictionary<string, List<int>>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split(" ");
                List<int> heroData = new List<int>();
                heroData.Add(int.Parse(tokens[1]));
                heroData.Add(int.Parse(tokens[2]));
                dict.Add(tokens[0], heroData);
            }
            var command = Console.ReadLine();
            while (command != "End")
            {
                var arr = command.Split(" - ");
                var name = arr[1];
                var value = int.Parse(arr[2]);
                if (arr[0] == "CastSpell")
                {
                    var spellName = arr[3];
                    if (dict[name][1] >= value)
                    {
                        dict[name][1] -= value;
                        Console.WriteLine($"{name} has successfully cast {spellName} and now has {dict[name][1]} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{name} does not have enough MP to cast {spellName}!");
                    }
                }
                else if (arr[0] == "TakeDamage")
                {
                    var attacker = arr[3];
                    dict[name][0] -= value;
                    if (dict[name][0] <= 0)
                    {
                        Console.WriteLine($"{name} has been killed by {attacker}!");
                        dict.Remove(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} was hit for {value} HP by {attacker} and now has {dict[name][0]} HP left!");
                        
                    }
                }
                else if (arr[0] == "Recharge")
                {
                    var diff = 0;
                    if ((dict[name][1] + value) >= 200 || dict[name][1] > 200)
                    {
                        diff = 200 - dict[name][1];
                        dict[name][1] = 200;
                        Console.WriteLine($"{name} recharged for {diff} MP!");
                    }
                    else
                    {
                        dict[name][1] += value;
                        Console.WriteLine($"{name} recharged for {value} MP!");
                    }
                }
                else if (arr[0] == "Heal")
                {
                    var diff = 0;
                    if ((dict[name][0] + value) >= 100 || dict[name][0] > 100)
                    {
                        diff = 100 - dict[name][0];
                        dict[name][0] = 100;
                        Console.WriteLine($"{name} healed for {diff} HP!");
                    }
                    else
                    {
                        dict[name][0] += value;
                        Console.WriteLine($"{name} healed for {value} HP!");
                    }
                }
                command = Console.ReadLine();
            }
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} \n  HP: {item.Value[0]}\n  MP: {item.Value[1]}");
            }
        }
    }
}
