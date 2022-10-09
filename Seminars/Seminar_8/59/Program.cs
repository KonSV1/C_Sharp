// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец
// на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим 
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7

Console.Clear();
int m = Convert.ToInt32(new Random().Next(4,7));
int n = m;
int[,] arrey = new int[m, n];
int[,] arrey1 = new int[arrey.GetLength(0) - 1, arrey.GetLength(1) - 1];
FillArrey();
PrintArrey(arrey);
SerchArrey();
PrintArrey(arrey1);



void SerchArrey()
{
    int min = arrey[0, 0];
    int mini = 0;
    int minj = 0;
    for (int i = 0; i < arrey.GetLength(0); i++)
    {
        for (int j = 0; j < arrey.GetLength(1); j++)
        {
            if (arrey[i, j] < min)
            {
                min = arrey[i, j];
                mini = i;
                minj = j;
            }
        }
    }
    Console.Write($"Наименьший элемент массива равен: {min}, размещен в {mini}-ой строке, в {minj}-ом столбце");
    Console.WriteLine("Новый массив без данных строки и столбца");
    int row = 0;
    for (int i = 0; i < m; i++)
    {
        if (i != mini)
        {
            int colum = 0;
            for (int j = 0; j < n; j++)
            {
                if (j != minj)
                {
                    arrey1[row, colum] = arrey[i, j];
                    colum++;
                }
            }
            row++;
        }
    }
}

void FillArrey()
{
    for (int i = 0; i < arrey.GetLength(0); i++)
    {
        for (int j = 0; j < arrey.GetLength(1); j++)
        {
            arrey[i, j] = new Random().Next(0, 300);
        }
    }
}

void PrintArrey(int[,] arr)
{
    Console.WriteLine();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write("{0,-6}", arr[i, j]);
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
