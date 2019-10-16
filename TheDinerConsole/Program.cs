using System;
using System.Collections.Generic;
using System.Text;

namespace TheDinerConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            FoodMenu summerMenu = new FoodMenu();
            summerMenu.Name = "Summer Menu";

            summerMenu.AddMenuItem("Salmon", "Fresh Norwegian Salmon", 25.50);
            summerMenu.AddMenuItem("Taco", "Tacos from TX", 7.00);
            summerMenu.HospitalDirections = "18500 Katy Fwy, Houston, TX 77094";

            DrinkMenu outsideDrinks = new DrinkMenu();
            outsideDrinks.Disclaimer = "Do not drink and code";
            outsideDrinks.AddMenuItem("Cuba Libre", "Classic", 10.00);
            outsideDrinks.AddMenuItem("Screwdriver", "Hammered!!!", 15.00);

            Order hungryGuestOrder = new Order();

            for (int i = 0; i <= summerMenu.items.Count; i++)
            {
                MenuItem currentItem = summerMenu.items[i];
                hungryGuestOrder.items.Add(currentItem);
            }

            foreach (MenuItem currentItem in outsideDrinks.items)
            {
                hungryGuestOrder.items.Add(currentItem);
            }
            Console.WriteLine("Done");
        }
    }
}
