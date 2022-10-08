// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

Console.Clear();
Console.Write("Введите количество строк в массиве ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] arrey = new int[m,n];
FillArrey();
PrintArrey();



void FillArrey() // Метод создания двумерного массива (m,n) элементов, и заполенения ПСВЧ [0,9]
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
    Console.WriteLine($"m = {m}; n = {n}"); 
    for (int i = 0; i < arrey.GetLength(0); i++)     
    {
        for (int j = 0; j < arrey.GetLength(1); j++)   
        {
            Console.Write($"{arrey[i, j]} ");
        }
        Console.WriteLine();
    }
}
