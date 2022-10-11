// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5


Console.Clear();
Console.Write("Введите количество строк в массиве ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] arrey = new int[m, n];
FillArrey();
PrintArrey();



void FillArrey() // Метод создания двумерного массива (m,n) элементов, и заполенения ПСВЧ [0,9]
{
    for (int i = 0; i < arrey.GetLength(0); i++)     // GetLength(0) - определяет сколько в массиве строк
    {
        for (int j = 0; j < arrey.GetLength(1); j++)   // GetLength(1) - определяет сколько в массиве столбцов
        {
            arrey[i, j] = i + j;
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
            Console.Write("{0, -3}", arrey[i, j]);
        }
        Console.WriteLine();
    }
}
