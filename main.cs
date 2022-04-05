// Created by: Joanne Santhosh
// Created on: Apr 2022
//
// This program calculates the volume of a sphere

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This program calculates the volume of a sphere
        double radiusOfTheSphere;
        double volume;
        Console.WriteLine("This program calculates the volume of a sphere.");
        Console.WriteLine("");

        Console.WriteLine("Enter the radius.");
        radiusOfTheSphere = (Convert.ToInt32(Console.ReadLine()));
        Console.WriteLine("");
        volume = (double)4 /(double)3 * Math.PI * (radiusOfTheSphere * radiusOfTheSphere * radiusOfTheSphere);
        Console.WriteLine("");
        Console.Write("volume of the sphere = " + volume.ToString("0.00") + "cm³");

        Console.WriteLine("\nDone.");
    }
}