﻿// Задача 9. Напишите программу, которая выводит случайное число
//из отрезка [10, 99] и показывает наибольшую цифру числа
//78 -> 8
//12 -> 2
//85 -> 8

Console.Clear();
int A = new Random().Next(10, 100);
int A1 = A / 10;
int A2 = A % 10;
if(A1 > A2)
{
    Console.WriteLine($"{A} --> {A1}");
}
else
{
    Console.WriteLine($"{A} --> {A2}");
}