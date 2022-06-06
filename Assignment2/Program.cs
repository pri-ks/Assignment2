using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Program
    {
        static void Main()
        {
            int length, width;
            Console.WriteLine("Rectangle Operations");
            Console.Write("Please enter the length of the rectangle: ");
            bool isIntLength = int.TryParse(Console.ReadLine(), out length);
            while (isIntLength == false || length < 1)
            {
                Console.WriteLine("Please enter a valid integer value greater than zero!");
                isIntLength = int.TryParse(Console.ReadLine(), out length);
            }
            Console.Write("\n");
            Console.Write("Please enter the width of the rectangle: ");
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
                        Console.WriteLine("Rectangle's Length is " + rect.GetLength());
                        break;
                    case 2:
                        Console.WriteLine("Please enter new length of the rectangle: ");
                        while (!int.TryParse(Console.ReadLine(), out length))
                        {
                            Console.WriteLine("Please enter a valid integer value!");
                        }
                        Console.WriteLine("Rectangle's length is set to " + rect.SetLength(length));
                        break;
                    case 3:
                        Console.WriteLine("Rectangle's Width is " + rect.GetWidth());
                        break;
                    case 4:
                        Console.WriteLine("Please enter new width of the rectangle: ");
                        while (!int.TryParse(Console.ReadLine(), out width))
                        {
                            Console.WriteLine("Please enter a valid integer value!");
                        }
                        Console.WriteLine("Rectangle's length is set to " + rect.SetWidth(width));
                        break;
                    case 5:
                        Console.WriteLine("Rectangle's Perimeter is " + rect.GetPerimeter());
                        break;
                    case 6:
                        Console.WriteLine("Rectangle's Area is " + rect.GetArea());
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
