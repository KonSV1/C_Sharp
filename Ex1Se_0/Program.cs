﻿// Запросить число
// Вывести на экран значение квадрата данного числа
Console.Clear();
Console.Write("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());
int res = num * num;
Console.WriteLine($"Квадрат числа {num} = {res}");