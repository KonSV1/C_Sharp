﻿// - Задача 56
//Задайте прямоугольный двумерный массив. напишите программу которая будет находить строку с наименьшей суммой элементов

Console.Clear();
int m = new Random().Next(4, 9);
int n = new Random().Next(4, 9);
int[,] arrey = new int[m, n];
FillArrey();
PrintArrey(arrey);
SerchMinSumm(arrey);



void FillArrey()
{
    for (int i = 0; i < arrey.GetLength(0); i++)
    {
        for (int j = 0; j < arrey.GetLength(1); j++)
        {
            arrey[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArrey(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write("{0,-4}", arr[i, j]);
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


void SerchMinSumm(int[,] arr)
{
    int[] store = new int[m];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int summ = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            summ = summ + arr[i, j];
        }
        store[i] = summ;
    }
    int minPos = 0;
    int minSumm = store[0];
    for (int i = 1; i < store.Length; i++)
    {
        if (store[i] < minSumm)
        {
            minSumm = store[i];
            minPos = i;
        }
    }
    Console.Write($" Наименьшая сумма элементов в строке № {minPos + 1} и равна {minSumm}");
}