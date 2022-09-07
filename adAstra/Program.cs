using System;
using System.Text.RegularExpressions;

namespace adAstra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string regex = @"(#|\|)(?<prod>[A-Za-z]+)(#|\|)(?<date>\d{1,}/\d{1,}/\d{1,})(#|\|)(?<calories>\d{1,})(#|\|)";
            Regex reg = new Regex(regex);
            var sentence = Console.ReadLine();
            MatchCollection match = Regex.Matches(sentence ,regex);

            //Console.WriteLine(match.Groups["calories"].Value);
            var days = 0;
            /*while (int.Parse(match["calories"].Value) > 0)
            {

            }*/
            Console.WriteLine(match["calories"].Value);
            foreach (Match match1 in match)
            {
                //Console.WriteLine(match1.Groups["prod"].Value);

                if (int.Parse(match1.Groups["calories"].Value) >= 2000)
                {
                    var diff = Math.Floor(double.Parse(match1.Groups["calories"].Value) / 2000);
                    Console.WriteLine($"You have food to last you for: {diff} days!");
                }
             
                Console.WriteLine($"Item: {match1.Groups["prod"]}, Best before: {match1.Groups["date"]}, Nutrition: {match1.Groups["calories"]}");
            }
        }
    }
}
