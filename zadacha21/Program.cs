
//      using System;

// namespace Seminar3
// {
//     class Program
//     {
//        static void Main(string[] args)
//         { 
     //Задача 21: Напишите программу, которая принимает на вход координаты двух точек 
    //  и находит расстояние между ними в 2D пространстве.
//   static void DistanceBetweenPoints(int x1, int x2, int y1, int y2)
//         {
//             {
//             double distanceBetweenPoints = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));

//             Console.WriteLine($"Distance Between Points={distanceBetweenPoints:f2}");
//         }
        
//         }
//     }
// }
// }


////Напишите программу, которая принимает на вход координаты двух точек и 
////находит расстояние между ними в 2D пространстве.

Console.WriteLine("Enter x1...");
int x1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Enter y1...");
int y1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Enter x2...");
int x2 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Enter y2...");
int y2 = int.Parse(Console.ReadLine()!);

double result = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));

Console.WriteLine("длинна отрезка"+result);

Console.WriteLine($"A ({x1},{y1}); B ({x2},{y2}) = {result:f3}");
