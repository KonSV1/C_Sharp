// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

Console.Clear();
Console.Write("Введите количество строк в массиве ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] arrey = new int[m, n];
FillArrey();
PrintArrey();
Result();



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
    for (int i = 0; i < arrey.GetLength(0); i++)
    {
        for (int j = 0; j < arrey.GetLength(1); j++)
        {
            Console.Write($"{arrey[i, j]} ");
        }
        Console.WriteLine();
    }
}

void Result()
{
    Console.Write("Сумма элементов главной диагонали: ");
    int s = 0;
    for (int i = 0; i < arrey.GetLength(0); i++)
    {
        for(int j = 0; j < arrey.GetLength(1); j++)
        {
            if(i == j )
            {
                Console.Write($"{arrey[i,j]} ");
                s = s + arrey[i,j];
            }
        }
    }
    Console.Write($" = {s}");
}