// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы в каждой строке массива.

Console.Clear();
int m = new Random().Next(4, 10);
int n = new Random().Next(4, 10);
int[,] arrey = new int[m, n];

FillArrey();
PrintArrey(arrey);
LineSortArrey(arrey);
PrintArrey(arrey);



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

void LineSortArrey(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            int maxj = j;
            for (int k = j + 1; k < arr.GetLength(1); k++)
            {
                if (arr[i, k] > arr[i, maxj]) maxj = k;
            }
            int temp = arrey[i, j];
            arr[i, j] = arr[i, maxj];
            arr[i, maxj] = temp;
        }
    }
}
