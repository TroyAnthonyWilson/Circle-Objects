﻿    namespace Circle_Objects
{
    internal class Program
    {
        public static string lineBreak = "====================================";
        static void Main()
        {
            List<Circle> circles = new();

            Console.WriteLine(lineBreak);
            Console.WriteLine("Welcome to Troy's circle tester");
            Console.WriteLine(lineBreak);
            Console.WriteLine();
            Console.Write("Please enter the radius of a circle: ");

            circles.Add(new Circle(102));
            circles.Add(new Circle(202));
            circles.Add(new Circle(10));

            Console.WriteLine();
            Console.WriteLine(lineBreak);
            Console.WriteLine($"Godbye! You made {circles.Count} circles.");
            Console.WriteLine($"With a total area of {Circle.FormatNumber(circles.Sum(n => n.CalculateArea()))}");
            Console.WriteLine(lineBreak);
        }
    }
}