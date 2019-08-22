using System;
using System.Collections.Generic;
using System.Text;

namespace OOPTutorial
{
  public class Rectangle
  {
    public int height { get; set; }
    public int width { get; set; }

    public Rectangle(int height, int width)
    {
      this.height = height;
      this.width = width;
    }

    public Rectangle()
    {

    }
    
    public int getArea()
    {
      int area = height * width;
      return area;
    }
  }
}
