﻿////Напишите программу, которая принимает на вход число (N) и выдаёт таблицу 
////квадратов чисел от 1 до N.

Console.WriteLine("Enter number...");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Таблица квадратов");

for(int i = 1;i<=number;i++)
{
        Console.WriteLine(Math.Pow(i,2));
}