//Задача 55: 
//Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
//В случае, если это невозможно, программа должна вывести сообщение для пользователя.

Console.Clear();
Console.Write("Введите количество строк в массиве ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] arrey = new int[m, n];
int[,] arrey1 = new int[m, n];
if (m != n)
{
    Console.Write($"Замена невозможна");
}
else
{
    FillArrey();
    PrintArrey(arrey);
    ZamenaArrey();
    PrintArrey(arrey1);
}

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

void ZamenaArrey()
{
    for (int i = 0; i < arrey.GetLength(0); i++)
    {
        for (int j = 0; j < arrey.GetLength(1); j++)
        {
            arrey1[i,j] = arrey[j, i];
        }
    }
}

void PrintArrey(int[,] arr)
{

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write("{0,-5}", arr[i, j]);
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}