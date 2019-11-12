using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 装饰者模式.书上的实现;

namespace 装饰者模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage beverage = new 装饰者模式.书上的实现.DrinkEspresso();
            Console.WriteLine(beverage.GetDescription() + ", Cost: " + beverage.Cost());

            Beverage beverage2 = new 装饰者模式.书上的实现.DrinkDarkRoast();
            beverage2 = new DecorMocha(beverage2);
            beverage2 = new DecorMocha(beverage2);
            beverage2 = new DecorWhip(beverage2);
            Console.WriteLine(beverage2.GetDescription() + ", Cost: " + beverage2.Cost());

            Beverage beverage3 = new 装饰者模式.书上的实现.DrinkHouseBlend();
            beverage3 = new DecorSoy(beverage3);
            beverage3 = new DecorMocha(beverage3);
            beverage3 = new DecorWhip(beverage3);
            Console.WriteLine(beverage3.GetDescription() + ", Cost: " + beverage3.Cost());

            Console.ReadLine();
        }

        static void MyImplement()
        {
            DrinkDarkRoast drinkDarkRoast = new DrinkDarkRoast("黑玫瑰");
            drinkDarkRoast.PrintDescription();
            drinkDarkRoast.lstSeason.Add(new Seasoning { Name = "黑珍珠", Amount = 1, Comment = "加1份黑珍珠", Price = 3 });
            drinkDarkRoast.lstSeason.Add(new Seasoning { Name = "红豆", Amount = 1.5, Comment = "加1.5份红豆", Price = 5 });
            drinkDarkRoast.PrintDescription();


            DrinkEspresso drinkEspresso = new DrinkEspresso("DrinkEspresso", 50);
            drinkEspresso.PrintDescription();
            drinkEspresso.lstSeason.Add(new Seasoning { Name = "黑珍珠", Amount = 1, Comment = "加1份黑珍珠", Price = 3 });
            drinkEspresso.lstSeason.Add(new Seasoning { Name = "红豆", Amount = 1.5, Comment = "加1.5份红豆", Price = 5 });
            drinkEspresso.PrintDescription();

            Console.ReadLine();
        }
    }
}
