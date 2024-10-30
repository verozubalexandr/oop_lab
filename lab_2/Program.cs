using System;
using lab_2.Constructions;

class Program
{
    static void Main()
    {
        var construction = new Construction(29.7f, 45.4f, 5, 124, "Material");

        Console.WriteLine("Height: " + construction.Height);
        Console.WriteLine("Width: " + construction.Width);
        Console.WriteLine("Entrances: " + construction.Entrances);
        Console.WriteLine("Human Capacity: " + construction.HumanCapacity);
        Console.WriteLine("Build Material: " + construction.BuildMaterial);

        try
        {
            construction.BuildMaterial = "";
        }
        catch (ArgumentNullException ex)
        {
            Console.WriteLine("Exception caught: " + ex.Message);
        }
    }
}