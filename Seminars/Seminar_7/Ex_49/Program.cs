// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
// Например, изначально массив
//  выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Новый массив будет выглядеть 
// вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4

Console.Clear();
Console.Write("Введите количество строк в массиве ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] arrey = new int[m, n];
FillArrey();
PrintArrey();
PrintResult();



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

void PrintArrey()
{
    Console.WriteLine("Оригинальный массив");
    for (int i = 0; i < arrey.GetLength(0); i++)
    {
        for (int j = 0; j < arrey.GetLength(1); j++)
        {
            Console.Write($"{arrey[i, j]} ");
        }
        Console.WriteLine();
    }
}

void PrintResult()
{
    Console.WriteLine("Измененный массив");
    for (int i = 0; i < arrey.GetLength(0); i++)
    {
        for (int j = 0; j < arrey.GetLength(1); j++)
        {
            if ((i % 2 == 0) && (j % 2 == 0) && (i != 0) && (j != 0))
            {
                arrey[i, j] = arrey[i, j] * arrey[i, j];
            }
            Console.Write($"{arrey[i, j]} ");
        }
        Console.WriteLine();
    }
}
