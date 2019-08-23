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

      Ingredient ingredient1 = new Ingredient { name = "potatoes" };
      Ingredient ingredient2 = new Ingredient { name = "tomatoes" };
      Ingredient ingredient3 = new Ingredient { name = "carrots" };
      Ingredient ingredient4 = new Ingredient { name = "onions" };


      List<Ingredient> list1 = new List<Ingredient> { ingredient1, ingredient2};
      List<Ingredient> list2 = new List<Ingredient> { ingredient3, ingredient2 };
      List<Ingredient> list3 = new List<Ingredient> { ingredient3, ingredient4 };

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
        price = 10,
        recipe = list1
      };

      Dish dish2 = new Dish
      {
        name = "Mousakas",
        chef = maria,
        price = 20,
        recipe =list2
      };

      Dish dish3 = new Dish
      {
        name = "Kotopoulo",
        chef = maria,
        price = 40,
        recipe = list3
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
      List<Ingredient> ingredients = order.getAllIngredients();

      foreach (var ingredient in ingredients)
      {
        Console.WriteLine(ingredient);
      }

      Console.WriteLine(maria);

      order.getNumOfOccurences();
  
     





    }
  }
}
