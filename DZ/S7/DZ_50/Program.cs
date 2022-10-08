// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.Clear();
Console.Write("Введите номер строки в массиве ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца в массиве ");
int colum = Convert.ToInt32(Console.ReadLine());
int m = new Random().Next(1, 10);
int n = new Random().Next(1, 10);
int[,] arrey = new int[m, n];

FillArrey();
PrintArrey();
SerchIndex();



void FillArrey() 
{
    for (int i = 0; i < arrey.GetLength(0); i++)     // GetLength(0) - определяет сколько в массиве строк
    {
        for (int j = 0; j < arrey.GetLength(1); j++)   // GetLength(1) - определяет сколько в массиве столбцов
        {
            arrey[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArrey()
{
    for (int i = 0; i < arrey.GetLength(0); i++)
    {
        for (int j = 0; j < arrey.GetLength(1); j++)
        {
            Console.Write($"{arrey[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void SerchIndex()
{
    if ((row > arrey.GetLength(0)) || (colum > arrey.GetLength(1)))
    {
        Console.Write($"В массиве нет числа на позиции {row}-я строка, {colum}-й столбец");
    }
    else
    {
        Console.Write($"На позиции {row}-я строка, {colum}-й столбец находится число {arrey[row-1,colum-1]}");
    }
}