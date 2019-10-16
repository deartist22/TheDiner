using System;
using System.Collections.Generic;
using System.Text;

namespace TheDinerConsole
{
    public class Order
    {
        public List<MenuItem> items = new List<MenuItem>(); 

        public double Total
        {

            get
            {
                double calculatedTotal = 0;
                foreach (MenuItem item in items)
                {
                    calculatedTotal += item.Price;
                }
                return calculatedTotal;
            }

        }
    }
}
