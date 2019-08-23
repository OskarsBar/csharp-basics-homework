using System;

namespace VariablesAndNames
{
    class Program
    {
        private static void Main(string[] args)
        {
            int cars;
            int drivers;
            int passengers;
            int carNotDriven;
            int carsDriven;
            int seatsInCar;
            double carpoolCapacity;
            double avaragePassangerPerCar;

            cars = 100; 
            seatsInCar = 4; 
            drivers = 43; 
            passengers = 90; 
            carNotDriven = cars - drivers; // free cars
            carsDriven = drivers; // cars driven at the moment
            carpoolCapacity = carsDriven * seatsInCar; 
            avaragePassangerPerCar = (double)passengers / (double)carsDriven; 

            Console.WriteLine($"There are {cars.ToString("F2")} cars available.");
            Console.WriteLine($"There are only {drivers} drivers available.");
            Console.WriteLine($"There will be {carNotDriven} empty cars today.");
            Console.WriteLine($"We can transport {carpoolCapacity} people today.");
            Console.WriteLine($"We have { passengers} to carpool today.");
            Console.WriteLine($"We need to put about { avaragePassangerPerCar.ToString("F2")} in each car.");
            Console.Read();
        }
    }
}