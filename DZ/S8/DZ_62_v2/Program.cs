// Заполните массив 4*4 спирально (улитка)

Console.Clear();
int rows = 4;
int colums = 4;
int[,] arrey = new int[rows, colums];
int x = 0;
int round = 0;
while (x <= rows * colums - 1)
{
    for (int j = round ; j < colums - round; j++)        //Заполняем гоизонталь вправо    
    {
        arrey[round, j] = x;
        x++;
    }
    for (int i = rows + 1 - (rows - round); i < rows - round; i++)    // Заполняем вертикаль вниз
    {
        arrey[i, colums - round - 1] = x;
        x++;
    }
    for (int j = colums - round - 2; j >= colums - (colums - round); j--)   //Заполняем горизонталь влево
    {
        arrey[rows - round - 1, j] = x;
        x++;
    }
    for (int i = rows - round - 2; i > rows - rows + round; i--)         // Заполняем вертикаль вверх
    {
        arrey[i, colums - colums + round] = x;
        x++;
    }
    round++;
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