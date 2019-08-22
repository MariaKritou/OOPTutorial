using System;
using System.Collections.Generic;
using System.Text;

namespace OOPTutorial
{
  public class Person
  {
    public string name { get; set; }
    public string surname { get; set; }
    public int age { get; set; } 
    public string getFullName()
    {
      string fullName = $"{name} {surname}";
      return fullName;
    }
  }
}
