using System;
using System.Collections.Generic;
using System.Text;

namespace YourFavoriteThings.Toppings
{
    class Sauce
    {
				private int SauceBawss;

				public string SauceChoice { get; set;}

				public void DefSauce()
				{
					Console.WriteLine("What kind of sauce woud you like?");
					Console.WriteLine("1) Green");
					Console.WriteLine("2) Mild");
					Console.WriteLine("3) Pineaple");
					Console.WriteLine("4) Hot");
					Console.WriteLine("or 5) Supah Hot?");
					Console.WriteLine("Please pick 1 - 5");
					var myChoice = Console.ReadLine();
					SauceBawss = Convert.ToInt32(myChoice);
					SauceofChoice();
				}

				private void SauceofChoice()
				{
					switch (SauceBawss)
					{
						case 1:
							SauceChoice = "Green";
							break;
						case 2:
							SauceChoice = "Mild";
							break;
						case 3:
							SauceChoice = "Pineapple";
							break;
						case 4:
							SauceChoice = "Hot";
							break;
				    case 5:
							SauceChoice = "Supah Hot";
							break;
					}
				}
		}
}
