using System;

namespace CalculationArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Start();
        }
        static void Start()
        {
            Console.WriteLine("You have opened a Form for area calculations!");
            Console.WriteLine();
            Menu();
        }
        static void Menu()
        {
            Console.WriteLine("Please choose your next action:");
            Console.WriteLine();
            Console.WriteLine(@"> For calculating circle area press - 1
> For calculating square area press - 2
> For exiting the form press any key on a keyboard");
            Console.WriteLine();

            string inputChoice = Console.ReadLine();
            
            switch (inputChoice)
            {
                case "1":
                    Circle();
                    break;
                case "2":
                    Square();
                    break;
                default:
                    break;
            }
        }
        static void Circle()
        {
            Console.WriteLine();
            Console.WriteLine("Please input number of radius: ");
            string inputRadius = Console.ReadLine();
            double radius = Convert.ToDouble(inputRadius);
            GetResultCircle(radius);
            Console.WriteLine($"Area for circle with radius {radius} is: " + GetResultCircle(radius));
            Console.ReadLine();
            Menu();
        }
        static double GetResultCircle(double radius)
            {
              return Math.PI * radius * radius;         
            }
        static void Square()
        {
            Console.WriteLine();
            Console.WriteLine("Please input number of square side: ");
            string inputSide = Console.ReadLine();
            double side = Convert.ToDouble(inputSide);
            GetResultSquare(side);
            Console.WriteLine($"Area for square with side {side} is: " + GetResultSquare(side));
            Console.ReadLine();
            Menu();
        }
        static double GetResultSquare(double side)
            {
                return side * side;
            }
      }
}
