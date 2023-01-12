using decorator_pattern.CoffeTypes;
using decorator_pattern.Condiments;

namespace decorator_pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Beverage beverage = new Espresso();
            Console.WriteLine(beverage.Description + " $" + beverage.Cost());

            Beverage beverage1 = new DarkRoast();
            beverage1.SetSize(Beverage.Size.VENTI);
            beverage1 = new Mocha(beverage1);
            beverage1 = new Mocha(beverage1);
            beverage1 = new Whip(beverage1);
            Console.WriteLine(beverage1.Description + " $" + beverage1.Cost());

            Beverage beverage2 = new HouseBlend();
            beverage1.SetSize(Beverage.Size.GRANDE);
            beverage2 = new Soy(beverage2);
            beverage2 = new Mocha(beverage2);
            beverage2 = new Whip(beverage2);
            Console.WriteLine(beverage2.Description + " $" + beverage2.Cost());

            Console.ReadLine();

        }
    }
}