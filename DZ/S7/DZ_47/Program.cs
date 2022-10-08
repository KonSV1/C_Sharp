// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Clear();
Console.Write("Введите количество строк в массиве ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] arrey = new double[m,n];
FillArrey();
PrintArrey();



void FillArrey() // Метод создания двумерного массива (m,n) элементов, и заполенения ПСВЧ [0,9]
{
    for (int i = 0; i < arrey.GetLength(0); i++)
    {
        for (int j = 0; j < arrey.GetLength(1); j++)
        {
            double v1 = new Random().Next(-9, 10);
            double v2= new Random().Next(1, 10);
            arrey[i, j] = Math.Round(v1/v2, 2);
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
            Console.Write($"{arrey[i, j]}   ");
        }
        Console.WriteLine();
    }
}
