// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

using System;

class Program {
    static void Main(string[] args) {
        Console.WriteLine("Введите координаты первой точки (x, y, z):");
        double x1 = double.Parse(Console.ReadLine());
        double y1 = double.Parse(Console.ReadLine());
        double z1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите координаты второй точки (x, y, z):");
        double x2 = double.Parse(Console.ReadLine());
        double y2 = double.Parse(Console.ReadLine());
        double z2 = double.Parse(Console.ReadLine());

        double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));

        Console.WriteLine($"Расстояние между точками ({x1}, {y1}, {z1}) и ({x2}, {y2}, {z2}) равно {distance}");
        Console.ReadKey();
    }
}

/*
using System;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите координаты первой точки (x1 y1 z1): ");
        string[] point1 = Console.ReadLine().Split();
        float x1 = Convert.ToSingle(point1[0]);
        float y1 = Convert.ToSingle(point1[1]);
        float z1 = Convert.ToSingle(point1[2]);

        Console.Write("Введите координаты второй точки (x2 y2 z2): ");
        string[] point2 = Console.ReadLine().Split();
        float x2 = Convert.ToSingle(point2[0]);
        float y2 = Convert.ToSingle(point2[1]);
        float z2 = Convert.ToSingle(point2[2]);

        Vector3 first = new Vector3(x1, y1, z1);
        Vector3 second = new Vector3(x2, y2, z2);
        float distance = Vector3.Distance(first, second);
        Console.WriteLine($"Расстояние между точками: {distance:F2}");
        Console.ReadLine();
    }
}


*/