using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.VehicleCatalogue
{
    public class VehicleCatalogue
    {
        public static void Main()
        {
            List<Venicle> cars = new List<Venicle>();
            List<Venicle> trucks = new List<Venicle>();
            string input = Console.ReadLine();
            while (input != "End")
            {
                string[] parts = input.Split(' ').ToArray();
                if (parts[0].ToLower() == "car")
                {
                    Venicle venicle = new Venicle
                    {
                        Type = "Car",
                        Model = parts[1],
                        Color = parts[2],
                        HorsePower = int.Parse(parts[3])
                    };
                    cars.Add(venicle);
                }
                else
                {
                    Venicle venicle = new Venicle
                    {
                        Type = "Truck",
                        Model = parts[1],
                        Color = parts[2],
                        HorsePower = int.Parse(parts[3])
                    };
                    trucks.Add(venicle);
                }
                input = Console.ReadLine();
            }

            List<Venicle> addedCars = new List<Venicle>();
            List<Venicle> addTracks = new List<Venicle>();
            string modelVenicle = Console.ReadLine();
            while (modelVenicle != "Close the Catalogue")
            {
                if (cars.Any(x => x.Model == modelVenicle))
                {
                    var existCar = cars.First(x => x.Model == modelVenicle);
                    Console.WriteLine($"Type: {existCar.Type}");
                    Console.WriteLine($"Model: {existCar.Model}");
                    Console.WriteLine($"Color: {existCar.Color}");
                    Console.WriteLine($"Horsepower: {existCar.HorsePower}");
                    addedCars.Add(existCar);
                }
                else
                {
                    var existTruck = trucks.First(x => x.Model == modelVenicle);
                    Console.WriteLine($"Type: {existTruck.Type}");
                    Console.WriteLine($"Model: {existTruck.Model}");
                    Console.WriteLine($"Color: {existTruck.Color}");
                    Console.WriteLine($"Horsepower: {existTruck.HorsePower}");
                    addTracks.Add(existTruck);
                }

                modelVenicle = Console.ReadLine();
            }

            Console.WriteLine("Cars have average horsepower of: {0:F2}.", cars.Count != 0 ? cars.Average(x => x.HorsePower) : 0);
            Console.WriteLine("Trucks have average horsepower of: {0:F2}.", trucks.Count != 0 ? trucks.Average(x => x.HorsePower) : 0);
        }
    }

    public class Venicle
    {
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int HorsePower { get; set; }
    }
}
