using System;
using System.Collections.Generic;
using System.Text;

namespace TheDinerConsole
{
    public class Menu
    {
        public string Name;
        public List<MenuItem> items;

        public Menu()
        {
            items = new List<MenuItem>();
        }

    }
}
