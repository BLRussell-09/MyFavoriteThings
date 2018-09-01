using System;
using System.Collections.Generic;
using System.Text;

namespace YourFavoriteThings.Toppings
{
    class Cheese
    {
		private int cheeseChoice;

		public string MyCheese { get; set;}

				public void DefCheese() 
        {
						Console.WriteLine("We have a few options for cheese here. Would you like");
            Console.WriteLine("1) Gouda");
			      Console.WriteLine("2) Velveta");
			      Console.WriteLine("or 3) Craft?");
						Console.WriteLine("Please pick 1, 2, or 3");
            var myChoice = Console.ReadLine();
						cheeseChoice = Convert.ToInt32(myChoice);
						CheeseofChoice();
		    }

				private void CheeseofChoice()
				{ 
						switch (cheeseChoice)
						{
								case 1: 
									MyCheese = "Gouda";
									break;
								case 2:
									MyCheese = "Velveta";
									break;
								case 3:
									MyCheese = "Craft";
									break;
						}
				}
    }
}
