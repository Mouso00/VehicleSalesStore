using System;
using System.Diagnostics.Metrics;
using VehicleSalesStore.Models;

namespace VehicleSalesStore
{

    class Program
    {
        public static List<Car> carList = new List<Car>();
        public static List<Bike> bikeList = new List<Bike>();  
        public static List<Vehicle> vehicleList = new List<Vehicle>();

        public static void Main(string[] args) 
        {
            
           bool showMenu = true;
            while (showMenu)
            {
                showMenu = mainMenu();
            }
        }
        private static bool mainMenu()
        {
            Console.Clear();
            Console.WriteLine("\rMain menu\n ");
            Console.WriteLine("1)Add a new Vehicle");
            Console.WriteLine("2)See the Vehicle Entries");
            Console.WriteLine("3)Exit");
            Console.WriteLine("\nPlease choose an option and press enter:");
            
            switch (Console.ReadLine())
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("\rWhat type of Vehicle you want to Add\n ");
                    Console.WriteLine("1) To Add a New Car: ");
                    Console.WriteLine("2) To Add a New Bike: ");
                    Console.WriteLine("\nPlease choose an option and press enter:");
                    switch (Console.ReadLine())
                    {
                        case"1":
                            addNewCar();
                            return true;
                        case "2":
                            addNewBike();
                            return true;
                        case "3":
                            return true;
                    }
                    return true;

                case "2":
                    Console.Clear();
                    Console.WriteLine("\rWhat type of Vehicle you want to see\n ");
                    Console.WriteLine("1) To See the Car entries:" );
                    Console.WriteLine("2) To See the Bike entries:");
                    Console.WriteLine("3) To See the All Vehicles entries:");
                    Console.WriteLine("\n:select an option please");
                    switch (Console.ReadLine())
                    {
                        case "1":
                            showCarEntries();
                            return true;
                        case "2":
                            showBikeEntries();
                            return true;
                        case "3":
                            showAllEntries();
                            return true;
                    }
                    return true;
                
                
                case "3":

                    return false;
                default:
                    return true;
            }
        }
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
            car.price = price;

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
            bike.price = price;

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
                Console.WriteLine("Car price: "+ price);

            }
            Console.ReadKey();
        }
        public static void showBikeEntries()
        {
            Console.Clear();
            foreach(var bike in bikeList)
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
                Console.WriteLine( maker);
                Console.ResetColor();

                Console.WriteLine("Vehicle Year: " + year);
                Console.WriteLine("Vehicle Price: "+ price);

            }
            Console.ReadKey();
            

        }


    }





}