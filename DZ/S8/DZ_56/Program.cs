// - Задача 56
//Задайте прямоугольный двумерный массив. напишите программу которая будет находить строку с наименьшей суммой элементов

Console.Clear();
int m = new Random().Next(4, 10);
int n = new Random().Next(4, 10);
int[,] arrey = new int[m, n];
FillArrey();
PrintArrey(arrey);
SerchMaxSumm(arrey);



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


void SerchMaxSumm(int[,] arr)
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
    int maxPos = 0;
    int maxSumm = store[0];
    for (int i = 1; i < store.Length; i++)
    {
        if (store[i] > maxSumm)
        {
            maxSumm = store[i];
            maxPos = i;
        }
    }
    Console.Write($" Наибольшая сумма элементов в строке № {maxPos + 1} и равна {maxSumm}");
}