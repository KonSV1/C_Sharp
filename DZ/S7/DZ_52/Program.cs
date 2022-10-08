// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


Console.Clear();
int m = 4; //new Random().Next(1, 10);
int n = 3; //new Random().Next(1, 10);
int[,] arrey = new int[m, n];

FillArrey();
PrintArrey();
PrintResult();



void FillArrey()
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
    Console.WriteLine();
}

void PrintResult() //метод подсчета среднего арифметического массива по столбцам
{
    Console.Write("Среднее арифметическое каждого столбца ");
    double[] v = new double[arrey.GetLength(1)];                //Создаем одномерный массив для записи результата
    for (int i = 0; i < arrey.GetLength(1); i++)                //Определяем размерность массива по столбцам
    {
        for (int j = 0; j < arrey.GetLength(0); j++)            //Определяем размерность массива по строкам
        {
            v[i] = v[i] + arrey[j, i];                          // меняем местами индексы для обеспечения считывания элементов по столбцам, а не по строкам 
        }
        v[i]= Math.Round(v[i] / arrey.GetLength(0),2);
    }
    for(int i = 0; i < v.Length -1; i++)
    {
        Console.Write($"{v[i]}; ");
    }
    Console.Write($"{v[v.Length - 1]}. ");
}
