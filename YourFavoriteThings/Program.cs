using System;
using YourFavoriteThings.Toppings;

namespace YourFavoriteThings
{
    class Program
    {
        static void Main(string[] args)
        {
            var meat = new Meat();
						var veggies = new Veggies();
						var cheese = new Cheese();
						var sauce = new Sauce();

						meat.Get();
						veggies.VeggiePicker();
            cheese.DefCheese();
						sauce.DefSauce();

						Console.WriteLine($"Our Taco has {meat.MyMeat} in it, with {veggies.Veg1}, {veggies.Veg2}, and {veggies.Veg3} for toppings. We have {cheese.MyCheese} cheese, and {sauce.SauceChoice} sauce on top.");
						Console.ReadLine();
        }
    }
}
