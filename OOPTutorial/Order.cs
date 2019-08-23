using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPTutorial
{
  public class Order
  {
    public List<Dish> dishes { get; set; }
    public double tipPercent { get; set; }

    List<Ingredient> listOfIngredients = new List<Ingredient> { };
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
 
    public List<Ingredient> getAllIngredients()
    {
    
      foreach (var dish in dishes)
      {
        listOfIngredients.AddRange(dish.recipe);
        //listOfIngredients.Concat(dish.recipe).ToList();

      }
    
      return listOfIngredients;
    }

    public void getNumOfOccurences()
    {
      var group = listOfIngredients.GroupBy(i => i);
      foreach (var occurence in group)
      {
        Console.WriteLine("{0} {1}", occurence.Key, occurence.Count());
      }
    }
    
   

  }
}
