using System;
using System.Collections.Generic;

namespace OOPTutorial
{
  class Program
  {
    static void Main(string[] args)
    {
      //Rectangle rectangle1 = new Rectangle();
      //Rectangle rectangle2 = new Rectangle(20,30);
      //Console.WriteLine($"width: {rectangle1.width}, height:{rectangle1.height}");

      //rectangle1.height = 20;
      //rectangle1.width = 50;

      //Console.WriteLine($"width: {rectangle1.width}, height:{rectangle1.height}");


      //int result =rectangle1.getArea();

      //Console.WriteLine(result);
      //Console.WriteLine();
      Chef maria = new Chef
      {
        name = "Maria",
        surname = "Kritou",
        age = 23
      };

      Dish dish1 = new Dish
      {
        name = "Pastitsio",
        chef = maria,
        price = 10
      };

      Dish dish2 = new Dish
      {
        name = "Mousakas",
        chef = maria,
        price = 20
      };

      List<Dish> dishes = new List<Dish> { dish1, dish2 };
       Order order = new Order
      {
        dishes= dishes,
        tipPercent = 0.5
     };

      double totalPrice = order.getTotalPrice();
      int price = order.getPrice();
      double tip = order.getTip();
      string receipt = order.getReceipt();

      Console.WriteLine(receipt);






    }
  }
}
