﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TheDinerConsole
{
    public class MenuItem
    {
        public string Title, Description;
        public double Price
        {
            get { return _price}
            set { if (value > 0) 
                {
                    _price = value;
                }
                else
                {
                    throw new ApplicationException("You cannot have free or negative valued items.");
                }
            }
                   
                        
        }

        private double _price;
    }
}
