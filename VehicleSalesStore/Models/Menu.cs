using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleSalesStore.Models
{
    class Menu
    {

        public static bool mainMenu()
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
                        case "1":
                            ShowAndAdd.addNewCar();
                            return true;
                        case "2":
                            ShowAndAdd.addNewBike();
                            return true;
                        case "3":
                            return true;
                    }
                    return true;

                case "2":
                    Console.Clear();
                    Console.WriteLine("\rWhat type of Vehicle you want to see\n ");
                    Console.WriteLine("1) To See the Car entries:");
                    Console.WriteLine("2) To See the Bike entries:");
                    Console.WriteLine("3) To See the All Vehicles entries:");
                    Console.WriteLine("\nplease select an option and press enter");
                    switch (Console.ReadLine())
                    {
                        case "1":
                            ShowAndAdd.showCarEntries();
                            return true;
                        case "2":
                            ShowAndAdd.showBikeEntries();
                            return true;
                        case "3":
                            ShowAndAdd.showAllEntries();
                            return true;
                    }
                    return true;


                case "3":

                    return false;
                default:
                    return true;
            }
        }
       
    }
}
