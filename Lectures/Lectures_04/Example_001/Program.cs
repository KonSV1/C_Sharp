// Двумерные массивы

string[,] table = new string[2,5];   // Создание массива из 2-х строк и 5-ти столбцов


table[1,2] = "Слово";

for (int rows = 0; rows < 2; rows ++)
{
    for (int colums = 0; colums < 5; colums++)
    {
        Console.WriteLine($"{table[rows, colums]} -");
    }
}

int[,] matrix = new int[3, 4];

for (int i = 0; i < matrix.GetLength(0); i ++)      // GetLength(0) - определяет сколько в массиве строк
{
    for (int j = 0; j < matrix.GetLength(1); j++)   // GetLength(1) - определяет сколько в массиве столбцов
    {
        Console.Write($"{matrix[i, j]} ");
    }
    Console.WriteLine();
}


//применение методов




void PrintArrey(int[,] matr)        // метод вывода на экран массива
{
    for (int i = 0; i < matr.GetLength(0); i ++)     
    {
        for (int j = 0; j < matr.GetLength(1); j++) 
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}


void FillArrey(int[,] matr)         //метод заполнения массива ПСП
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(1, 10);
        }
    }
}


//int[,] matrix = new int[3, 4];
PrintArrey(matrix);
Console.WriteLine();
FillArrey(matrix);
PrintArrey(matrix);