﻿// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число:");
int N = Math.Abs(Convert.ToInt32(Console.ReadLine()));

Console.WriteLine();

for (int i = 1; i < N + 1; i++)
{
    Console.WriteLine(Math.Pow(i, 3));
}