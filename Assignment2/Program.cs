using System;

namespace Assignment2
{
    internal class Program
    {
        static void Main()
        {
            int length, width;
            Console.WriteLine("Rectangle Operations");
            Console.Write("\n");
            Console.Write("Please enter length of the rectangle (cm): ");
            bool isIntLength = int.TryParse(Console.ReadLine(), out length);
            while (isIntLength == false || length < 1)
            {
                Console.WriteLine("Please enter a valid integer value greater than zero!");
                isIntLength = int.TryParse(Console.ReadLine(), out length);
            }
            Console.Write("\n");
            Console.Write("Please enter width of the rectangle (cm): ");
            bool isIntWidth = int.TryParse(Console.ReadLine(), out width);
            while (isIntWidth == false || width < 1)
            {
                Console.WriteLine("Please enter a valid integer value greater than zero!");
                isIntWidth = int.TryParse(Console.ReadLine(), out width);
            }

            Rectangle rect = new Rectangle(length, width);
            while (true)
            {
                Console.Write("\n");
                Console.WriteLine("Enter any menu option from below to continue");
                Console.WriteLine("1. Get Rectangle Length");
                Console.WriteLine("2. Change Rectangle Length");
                Console.WriteLine("3. Get Rectangle Width");
                Console.WriteLine("4. Change Rectangle Width");
                Console.WriteLine("5. Get Rectangle Perimeter");
                Console.WriteLine("6. Get Rectangle Area");
                Console.WriteLine("7. Exit");
                int.TryParse(Console.ReadLine(), out int menuoption);
                Console.Write("\n");
                switch (menuoption)
                {
                    case 1:
                        Console.WriteLine("Rectangle's Length is " + rect.GetLength() + " cm");
                        break;
                    case 2:
                        Console.WriteLine("Please enter new length of the rectangle: ");
                        isIntLength = int.TryParse(Console.ReadLine(), out length);
                        while (isIntLength == false || length < 1)
                        {
                            Console.WriteLine("Please enter a valid integer value greater than zero!");
                            isIntLength = int.TryParse(Console.ReadLine(), out length);
                        }
                        Console.WriteLine("Rectangle's length is set to " + rect.SetLength(length) + " cm");
                        break;
                    case 3:
                        Console.WriteLine("Rectangle's Width is " + rect.GetWidth() + " cm");
                        break;
                    case 4:
                        Console.WriteLine("Please enter new width of the rectangle: ");
                        isIntWidth = int.TryParse(Console.ReadLine(), out width);
                        while (isIntWidth == false || width < 1)
                        {
                            Console.WriteLine("Please enter a valid integer value greater than zero!");
                            isIntWidth = int.TryParse(Console.ReadLine(), out width);
                        }
                        Console.WriteLine("Rectangle's width is set to " + rect.SetWidth(width) + " cm");
                        break;
                    case 5:
                        Console.WriteLine("Rectangle's Perimeter is " + rect.GetPerimeter() + " cm");
                        break;
                    case 6:
                        Console.WriteLine("Rectangle's Area is " + rect.GetArea() + " square cm");
                        break;
                    case 7:
                        return;
                    default:
                        Console.WriteLine("Please enter a valid menu option number");
                        break;
                }
            }
        }
    }
}