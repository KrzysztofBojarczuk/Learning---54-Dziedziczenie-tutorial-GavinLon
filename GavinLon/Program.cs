using System;
using System.Collections.Generic;
using System.Linq;

namespace GavinLon
{
    class Program
    {
        static void Main(string[] args)
        {
            Product desk = new Desk();

            ((Desk)desk).ImportTaxPercentage = 2;
            desk.Price = 100;
            desk.Add();
            desk.Add();
            Console.WriteLine("Totak value of desk in stock " + desk.GetTotalValueInStock());

            Product droneTurbo = new TurboDrone();
            droneTurbo.Price = 200;
            ((Drone)droneTurbo).QuantityIncremented = 10;

            droneTurbo.Add();
            droneTurbo.Add();
            Console.WriteLine("Drones Turbo " + droneTurbo.GetTotalValueInStock());

            Console.WriteLine();

            Product droneStandard = new StandardDrone();

            droneStandard.Price = 150;

            ((Drone)droneStandard).QuantityIncremented = 5;

            droneStandard.Add();
            droneStandard.Add();
            droneStandard.Add();


            //Product[] products = new Product[3];

            //products[0] = desk;
            //products[1] = droneStandard;
            //products[2] = droneTurbo;

            IList<Product> products = new List<Product>();

            products.Add(desk);
            products.Add(droneStandard);
            products.Add(droneTurbo);

            Console.WriteLine();
            Console.WriteLine("Stock Inventory Report");
            Console.WriteLine("_______________________");
            Console.WriteLine();

            foreach (Product product in products)
            {
                Console.WriteLine(product);
            }
            Console.WriteLine();
            decimal grandTotalStockValue = products.Sum(p => p.GetTotalValueInStock());

            Console.WriteLine($"Grand total of value of all products in stock: {grandTotalStockValue}");
            
        }
    }
}
