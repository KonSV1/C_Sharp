// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

Console.Clear();
Console.Write("Введите количество строк в массиве ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] arrey = new int[m,n];
FillArrey();
PrintArrey();
ZamenaArrey();
PrintArrey();


void ZamenaArrey()
{
    int temp = 0;
    for (int i = 0; i < arrey.GetLength(1); i++)
    {
        temp = arrey[0, i];
        arrey[0,i] = arrey[m-1,i];
        arrey[m-1,i] = temp;
    }
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

void PrintArrey()
{
    
    for (int i = 0; i < arrey.GetLength(0); i++)     
    {
        for (int j = 0; j < arrey.GetLength(1); j++)   
        {
            Console.Write("{0,-5}",arrey[i, j]);
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
