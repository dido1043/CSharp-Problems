using System;
using System.Collections.Generic;
namespace needForSpeed
{
    internal class Program
    {
        static void Main(string[] args)
        {
                   
            Dictionary<string, List<int>> cars = new Dictionary<string, List<int>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split("|");
                List<int> carData = new List<int>();
                carData.Add(int.Parse(input[1]));
                carData.Add(int.Parse(input[2]));
                cars.Add(input[0],carData);
            }
            var command = Console.ReadLine();
            
            while (command != "Stop")
            {
                var inputArr = command.Split(" : ");
                var carName = inputArr[1];
                var valueOne = int.Parse(inputArr[2]);
                if (inputArr[0] == "Drive")
                {                    
                    var fuelLevel = int.Parse(inputArr[3]);
                    if (cars[carName][1] < fuelLevel)
                    {
                        Console.WriteLine("Not enough fuel to make that ride");
                    }
                    else
                    {
                        cars[carName][0] += valueOne;
                        cars[carName][1] -= fuelLevel;
                        Console.WriteLine($"{carName} driven for {valueOne} kilometers. {fuelLevel} liters of fuel consumed.");
                    }
                    if (cars[carName][0] >= 100000)
                    {
                        Console.WriteLine($"Time to sell the {carName}!");
                        cars.Remove(carName);
                    }
                }
                else if (inputArr[0] == "Refuel")
                {
                    var diff=0;
                    var sum = cars[carName][1] + valueOne;

                    if ((cars[carName][1]+valueOne) >= 75 || cars[carName][1] > 75)
                    {
                        diff = 75 - cars[carName][1];
                        cars[carName][1] = 75;
                        Console.WriteLine($"{carName} refueled with {diff} liters");
                    }
                    else
                    {
                        cars[carName][1] += valueOne;
                        Console.WriteLine($"{carName} refueled with {valueOne} liters");
                    }

                    
                }
                else if (inputArr[0] == "Revert")
                {
                    cars[carName][0] -= valueOne;
                    if (cars[carName][0] <= 10000)
                    {
                        cars[carName][0] = 10000;
                    }
                    else
                    {
                        Console.WriteLine($"{carName} mileage decreased by {valueOne} kilometers");
                    }
                                        
                }                
                command = Console.ReadLine();
            
            }

            foreach (var item in cars)
            {
                Console.WriteLine($"{item.Key} -> Mileage: {item.Value[0]} kms, Fuel in the tank: {item.Value[1]} lt.");
            }
        }
    }
}
