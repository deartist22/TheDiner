using System;

namespace TheDinerConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu summerMenu = new Menu();
            summerMenu.Name = "Summer Menu";
            MenuItem salmon = new MenuItem();
            salmon.Title = "Salmon";
            salmon.Description = "Fresh Norwegian Salmon";
            salmon.Price = 25.50;
            summerMenu.items.Add(salmon);
            Console.WriteLine("Done");
        }
    }
}
