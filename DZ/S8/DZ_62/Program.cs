// Заполните массив 4*4 спирально (улитка)

Console.Clear();
int rows = 4;
int colums = 4;
int[,] arrey = new int[rows, colums];
int x = 0;
for (int j = 0; j < arrey.GetLength(1); j++)
{
    int i = 0;
    arrey[i, j] = x;
    x++;
}
for (int i = arrey.GetLength(0) - (arrey.GetLength(0) - 1); i < arrey.GetLength(0); i++)
{
    int j = arrey.GetLength(1) - 1;
    arrey[i, j] = x;
    x++;
}
for (int j = arrey.GetLength(1) - 2; j >= 0; j--)
{
    int i = arrey.GetLength(0) - 1;
    arrey[i, j] = x;
    x++;
}
for (int i = arrey.GetLength(0) - 2; i > 0; i--)
{
    int j = 0;
    arrey[i, j] = x;
    x++;
}
for (int j = 1; j < arrey.GetLength(1) - 1; j++)
{
    int i = 1;
    arrey[i, j] = x;
    x++;
}
for (int j = arrey.GetLength(1) - 2; j >= 1; j--)
{
    int i = arrey.GetLength(0) - 2;
    arrey[i, j] = x;
    x++;
}



PrintArrey(arrey);


void PrintArrey(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write("{0,-4}", arr[i, j]);
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}