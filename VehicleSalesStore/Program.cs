using System;
using System.Diagnostics.Metrics;
using VehicleSalesStore.Models;

namespace VehicleSalesStore
{
    class Program
    {
      

        public static void Main(string[] args) 
        {
            
           bool showMenu = true;
            while (showMenu)
            {
                showMenu = Menu.mainMenu();
            }
        }
       


    }





}