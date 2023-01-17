using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleSalesStore.Models
{
    class ShowAndAdd
    {
        public static List<Car> carList = new List<Car>();
        public static List<Bike> bikeList = new List<Bike>();
        public static List<Vehicle> vehicleList = new List<Vehicle>();

        public static void addNewCar()
        {
            Console.Clear();

            Car car = new Car();

            Console.WriteLine("Type the Maker of the Car : ");
            var maker = Console.ReadLine();
            car.maker = maker;

            Console.WriteLine("Type the year of the Car: ");
            var year = Console.ReadLine();
            car.year = year;

            Console.WriteLine("The the price of the Car");
            var price = Console.ReadLine();
            car.price = Convert.ToInt32(price);

            carList.Add(car);
            vehicleList.Add(car);
        }
        public static void addNewBike()
        {
            Console.Clear();
            Bike bike = new Bike();

            Console.WriteLine("Type the Maker of the Bike");
            var maker = Console.ReadLine();
            bike.maker = maker;

            Console.WriteLine("Type the year of the Bike");
            var year = Console.ReadLine();
            bike.year = year;

            Console.WriteLine("Type the price of the Bike");
            var price = Console.ReadLine();
            bike.price = Convert.ToInt32(price);

            bikeList.Add(bike);
            vehicleList.Add(bike);
        }
        public static void showCarEntries()
        {
            Console.Clear();
            foreach (var car in carList)
            {
                var maker = car.maker;
                var year = car.year;
                var price = car.price;

                Console.WriteLine("Car List");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(maker);
                Console.ResetColor();

                Console.WriteLine("Car year: " + year);
                Console.WriteLine("Car price: " + price);

            }
            Console.ReadKey();
        }
        public static void showBikeEntries()
        {
            Console.Clear();
            foreach (var bike in bikeList)
            {
                var maker = bike.maker;
                var year = bike.year;
                var price = bike.price;
                Console.WriteLine("Bike List");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(maker);
                Console.ResetColor();

                Console.WriteLine("Bike year: " + year);
                Console.WriteLine("Bike price " + price);
            }
            Console.ReadKey();
        }
        public static void showAllEntries()
        {
            Console.Clear();

            foreach (var vehicle in vehicleList)
            {
                var maker = vehicle.maker;
                var year = vehicle.year;
                var price = vehicle.price;
                Console.WriteLine("All vehicle List");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(maker);
                Console.ResetColor();

                Console.WriteLine("Vehicle Year: " + year);
                Console.WriteLine("Vehicle Price: " + price);

            }
            Console.ReadKey();


        }

    }
}
