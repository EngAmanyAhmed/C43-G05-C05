using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment05
{
    internal class Program
    {

        enum WeekDays
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        enum Season
        {
            Spring,
            Summer,
            Autumn,
            Winter
        }

        [Flags]
        enum Permissions
        {
            None = 0,           // 0b0000  
            Read = 1 << 0,     // 0b0001 (1)  
            Write = 1 << 1,    // 0b0010 (2)  
            Delete = 1 << 2,   // 0b0100 (4)  
            Execute = 1 << 3   // 0b1000 (8)  
        }

        enum Colors
        {
            Red,
            Green,
            Blue
        }
        static void Main(string[] args)
        {
            #region Problem 01

            // 1-	Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. Then, write a C# program that prints out all the days of the week using this enum.

            //Console.WriteLine("Days of the week:");

            //foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
            //{
            //    Console.WriteLine(day);
            //}

            #endregion

            #region Problem 02

            // 2.Create an enum called "Season" with the four seasons(Spring, Summer, Autumn, Winter) as its members.Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season. Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)

            //Console.WriteLine("Please enter a season (Spring, Summer, Autumn, Winter):");
            //string userInput = Console.ReadLine();


            //if (Enum.TryParse(userInput, true, out Season season))
            //{
            //    switch (season)
            //    {
            //        case Season.Spring:
            //            Console.WriteLine("Spring: March to May");
            //            break;
            //        case Season.Summer:
            //            Console.WriteLine("Summer: June to August");
            //            break;
            //        case Season.Autumn:
            //            Console.WriteLine("Autumn: September to November");
            //            break;
            //        case Season.Winter:
            //            Console.WriteLine("Winter: December to February");
            //            break;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid season entered. Please use Spring, Summer, Autumn, or Winter.");
            //}

            #endregion

            #region Problem 03

            // 3- Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum.
            // Create Variable from previous Enum to Add and Remove Permission from variable, check if specific Permission is existed inside variable


            //Console.WriteLine("Please enter a season (Spring, Summer, Autumn, Winter):");
            //string userInput = Console.ReadLine();

            //if (Enum.TryParse(userInput, true, out Season season))
            //{
            //    switch (season)
            //    {
            //        case Season.Spring:
            //            Console.WriteLine("Spring: March to May");
            //            break;
            //        case Season.Summer:
            //            Console.WriteLine("Summer: June to August");
            //            break;
            //        case Season.Autumn:
            //            Console.WriteLine("Autumn: September to November");
            //            break;
            //        case Season.Winter:
            //            Console.WriteLine("Winter: December to February");
            //            break;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid season entered. Please use Spring, Summer, Autumn, or Winter.");
            //}

            #endregion

            #region Problem 04

            //4. Create an enum called "Colors" with the basic colors (Red, Green, Blue) as its members. Write a C# program that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or not.


            //Console.WriteLine("Please enter a color (Red, Green, Blue):");
            //string userInput = Console.ReadLine();

            //if (Enum.TryParse(userInput, true, out Colors color))
            //{

            //    switch (color)
            //    {
            //        case Colors.Red:
            //        case Colors.Green:
            //        case Colors.Blue:
            //            Console.WriteLine($"{color} is a primary color.");
            //            break;
            //        default:
            //            Console.WriteLine($"{color} is not a primary color."); 
            //            break;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid color entered. Please use Red, Green, or Blue.");
            //}

            #endregion

        }
    }
}
