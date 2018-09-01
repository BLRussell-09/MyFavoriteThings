using System;
using System.Collections.Generic;
using System.Text;

namespace YourFavoriteThings.Toppings
{
    class Veggies
    {
				public string Veg1 { get; set; }
				public string Veg2 { get; set; }
				public string Veg3 { get; set; }

				public void VeggiePicker()
				{
						Console.WriteLine("You can pick 3 veggie toppings, so what would you like first?");
						Veg1 = Console.ReadLine();
						Console.WriteLine("What would you like for your second veggie topping?");
						Veg2 = Console.ReadLine();
						Console.WriteLine("What would you like your final veggie topping to be?");
						Veg3 = Console.ReadLine();
			  }
    }
}
