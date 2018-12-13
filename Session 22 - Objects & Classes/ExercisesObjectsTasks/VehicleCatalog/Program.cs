using System;
using System.Collections.Generic;
using System.Linq;

namespace VehicleCatalog
{

    class Vehicle
    {
        public string TypeVehicle { get; set; }
        public string ModelVehicle { get; set; }
        public string Color { get; set; }
        public int HorsePowers { get; set; }


        public Vehicle(string typeVehicle, string modelVehicle, string color, int horsePowers)
        {
            this.TypeVehicle = typeVehicle;
            this.ModelVehicle = modelVehicle;
            this.Color = color;
            this.HorsePowers = horsePowers;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            string[] splittedEntries = Console.ReadLine().Split();

            List<Vehicle> vehicles = new List<Vehicle>();


            while (splittedEntries[0] != "End")
            {
                string type = splittedEntries[0].ToUpper();
                string model = splittedEntries[1];
                string color = splittedEntries[2];
                int horsePowers = int.Parse(splittedEntries[3]);
                Vehicle vehicle = new Vehicle(type, model, color, horsePowers);
                vehicles.Add(vehicle);
                splittedEntries = Console.ReadLine().Split();
            }

            List<string> chosenModels = new List<string>();

            while (true)
            {
                string entryModel = Console.ReadLine();

                if (entryModel == "Close the Catalogue")
                {
                    decimal totalHorsePowerCars = 0;
                    decimal totalHorsePowerTruck = 0;
                    decimal avgHorsePowersCars = 0;
                    decimal avgHorsePwoersTrucks = 0;


                    if (vehicles.Where(x => x.TypeVehicle == "CAR").Count() > 0)
                    {
                        foreach (var vehicle in vehicles.Where(x => x.TypeVehicle == "CAR"))
                        {
                            totalHorsePowerCars += vehicle.HorsePowers;
                        }

                        int totalCountCars = vehicles.Where(x => x.TypeVehicle == "CAR").Count();
                        avgHorsePowersCars = totalHorsePowerCars / totalCountCars;
                    }

                    if (vehicles.Where(x => x.TypeVehicle == "TRUCK").Count() > 0)
                    {
                        foreach (var vehicle in vehicles.Where(x => x.TypeVehicle == "TRUCK"))
                        {
                            totalHorsePowerTruck += vehicle.HorsePowers;
                        }

                        int totalCountTruck = vehicles.Where(x => x.TypeVehicle == "TRUCK").Count();

                        avgHorsePwoersTrucks = totalHorsePowerTruck / totalCountTruck;
                    }


                    Console.WriteLine($"Cars have average horsepower of: {avgHorsePowersCars:F2}.");
                    Console.WriteLine($"Trucks have average horsepower of: {avgHorsePwoersTrucks:F2}.");
                    break;
                }

                foreach (var vehicle in vehicles.Where(x => x.ModelVehicle == entryModel))
                {
                    int index = vehicles.FindIndex(x => x.ModelVehicle == entryModel);
                    string typeVehicle = vehicles[index].TypeVehicle.ToLower();
                    typeVehicle = char.ToUpper(typeVehicle[0]) + typeVehicle.Substring(1);
                    Console.WriteLine($"Type: {typeVehicle}");
                    Console.WriteLine($"Model: {vehicles[index].ModelVehicle}");
                    Console.WriteLine($"Color: {vehicles[index].Color}");
                    Console.WriteLine($"Horsepower: {vehicles[index].HorsePowers}");
                }
            }
        }
    }
}
