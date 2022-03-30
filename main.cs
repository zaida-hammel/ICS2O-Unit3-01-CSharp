// Created by: Zaida Hammel
// Created on: March 2022
//
// This program accepts user input

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function calculates the area of a trapezoid
        int Basea;
        int Baseb;
        int Height;

        Console.WriteLine("This program calculates the area of a trapezoid.");
        Console.WriteLine("");
        Console.Write("Enter base A (mm): ");
        Basea = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter base B (mm): ");
        Baseb = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the height (mm): ");
        Height = Convert.ToInt32(Console.ReadLine());

        Double Area = Height * (Basea + Baseb) / 2;

        Console.WriteLine("");
        Console.Write("Area of the trapezoid = " + Area + " mm²");
        Console.ReadKey();
        Console.WriteLine("\nDone.");
    }
}