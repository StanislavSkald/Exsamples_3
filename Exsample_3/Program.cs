﻿// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Веедите число");
int numb = Convert.ToInt32(Console.ReadLine());
for (int count = 1; count <= numb; count++)
{
Console.WriteLine (Math.Pow(count, 3));
}