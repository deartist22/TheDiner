using System;
using System.Collections.Generic;
using System.Text;

namespace TheDinerConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu summerMenu = new Menu();
            summerMenu.Name = "Summer Menu";

            summerMenu.AddMenuItem("Salmon", "Fresh Norwegian Salmon", 25.50);
            summerMenu.AddMenuItem("Taco", "Tacos from TX", 7);

            Console.WriteLine("Done");
        }
    }
}
