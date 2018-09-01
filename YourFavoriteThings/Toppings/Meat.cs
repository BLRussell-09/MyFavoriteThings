using System;
using System.Collections.Generic;
using System.Text;

namespace YourFavoriteThings.Toppings
{
    class Meat
    {
				public string MyMeat { get; set;}

				public void Get()
				{ 
						Console.WriteLine("We are going to make tacos!");
						Console.WriteLine("What is your favorite kind of meat?");

						MyMeat = Console.ReadLine();
				}
    }
}
