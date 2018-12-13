using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabObjectsClassesTasks
{

    class Truck
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }
    }



    class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
    }


    class Catalog
    {
        public List<Car> Cars { get; set; }
        public List<Truck> Trucks { get; set; }
    }


    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            List<Truck> trucks = new List<Truck>();

            string command = Console.ReadLine();


            while (command != "end")
            {
                List<string> entries = command.Split(new [] {"/"},StringSplitOptions.RemoveEmptyEntries).ToList();
                string brand = entries[1];
                string model = entries[2];
                if (entries[0] == "Car")
                {
                    int horsePower = int.Parse(entries[3]);
                    Car car = new Car()
                    {
                        Brand = brand,
                        Model = model,
                        HorsePower = horsePower
                    };
                    cars.Add(car);
                }
                else
                {
                    int weight = int.Parse(entries[3]);
                    Truck truck = new Truck()
                    {
                        Brand = brand,
                        Model = model,
                        Weight = weight
                    };
                    trucks.Add(truck);
                }

                command = Console.ReadLine();
            }

            Catalog catalogs = new Catalog()
            {
                Cars = cars,
                Trucks = trucks
            };


            if (catalogs.Cars.Count > 0)
            {
                Console.WriteLine("Cars:");
                foreach (var car in catalogs.Cars.OrderBy(x => x.Brand))
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }


            if (catalogs.Trucks.Count > 0)
            {
                Console.WriteLine("Trucks:");


                foreach (var car in catalogs.Trucks.OrderBy(x => x.Brand))
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.Weight}kg");
                }
            }
        }
    }
}
