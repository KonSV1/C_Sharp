// задача 58
//задайте две матрицы. Напишите программу, которая будет находить произведения двух матриц

Console.Clear();
int mA = new Random().Next(3, 5);
int nA = new Random().Next(3, 5);
int[,] matrA = new int[mA, nA];
int mB = new Random().Next(3, 5);
int nB = new Random().Next(3, 5);
int[,] matrB = new int[mB, nB];
if (nA > nB)
{
    int[,] arrei = new int[mA, nA];
}
int[,] arrey = new int[mA, nB];
FillArrey(matrA);
FillArrey(matrB);
if (nA != mB)
{
    Console.WriteLine("Матрица А");
    PrintArrey(matrA);
    Console.WriteLine("Матрица B");
    PrintArrey(matrB);
    Console.WriteLine("Количество столбцов матрицы А не равно количеству строк матрицы В. Такие матрицы нельзя перемножить.");
}
else
{
    Console.WriteLine("Матрица А");
    PrintArrey(matrA);
    Console.WriteLine("Матрица B");
    PrintArrey(matrB);
    MultiplcationMatrAB(matrA, matrB);
    Console.WriteLine("Произведение Матрицы А на Матрицу B");
    PrintArrey(arrey);
}




void FillArrey(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(-9, 10);
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

void MultiplcationMatrAB(int[,] arr1, int[,] arr2)
{
    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr2.GetLength(1); j++)
        {
            int multUnit = 0;
            for (int k = 0; k < arr1.GetLength(1); k++)
            {
                multUnit = multUnit + arr1[i, k] * arr2[k, j];
            }
            arrey[i, j] = multUnit;
        }
    }
}