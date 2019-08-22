using System;
using System.Collections.Generic;
using System.Text;

namespace OOPTutorial
{
  public class Order
  {
    public List<Dish> dishes { get; set; }
    public double tipPercent { get; set; }

    public Order(List<Dish> dishes, double tipPercent)
    {
      this.dishes = dishes;     
      this.tipPercent = tipPercent;
    }

    public Order()
    {
    }

    public double getTip()
    {
      double result = getPrice() * tipPercent;
      return result;
    }

    public int getPrice()
    {
      int total = 0;

      foreach (var dish in dishes)
      {       
        total += dish.price;       
      }

      return total;
    }

    public double getTotalPrice()
    {
      double total = getPrice() + getTip();
      return total;
    }

    public void addDish(Dish dish)
    {
      dishes.Add(dish);
    }

    public void removeDish(Dish dish)
    {
      dishes.Remove(dish);
    }

    public string getReceipt()
    {
      
      string receipt= "";
      string title = "Name : Price\n";
      receipt += title;
      foreach (var dish in dishes)
      {
        receipt += $"{dish.name} : {dish.price}\n";
      }
      receipt += $"Price : {getPrice()}\n";
      receipt += $"Tip : {getTip()}\n";
      receipt += $"Total : {getTotalPrice()}\n";
      receipt += "Thank you";
      return receipt;
    }


  }
}
