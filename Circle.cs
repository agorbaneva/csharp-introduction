using System;

namespace Demo
{
    public class Circle
    {
        public double radius;
        public double x;
        public double y;
        public Circle(double r, double x = 0, double y = 0)
        {
            this.x = x;
            this.y = y;
            this.radius = r;
        }

        public double getArea()
        {
            return Math.PI * this.radius * this.radius;
        }
    }
    
  public static class Program
  {
    public static void Main(string[] args)
    {
        Circle origin = new Circle(5.0);
        Console.WriteLine("{0:F2}", origin.getArea());
    }
  }
}
