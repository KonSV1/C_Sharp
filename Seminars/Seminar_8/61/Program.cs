// Задача 61: Вывести первые N строк треугольника Паскаля.
//Сделать вывод в виде равнобедренного треугольника

Console.Clear();
Console.Write("Введите количество строк треугольника Паскаля -  ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] arrey = new int[n, n * 2 - 1];
arrey[0, n - 1] = 1;
arrey[1, n] = 1;
arrey[1, n - 2] = 1;
for (int i = 2; i < arrey.GetLength(0); i++)
{
    for (int j = 1; j < arrey.GetLength(1)-1; j++)
    {
        if ((j == 0) && (j == arrey.GetLength(1) - 1)) arrey[i, j] = 0;
        else arrey[i, j] = arrey[i - 1, j - 1] + arrey[i - 1, j+1];
    }
    arrey[arrey.GetLength(0)-1, arrey.GetLength(1)-1] = 1;
    arrey[arrey.GetLength(0)-1, 0] = 1;
}
PrintArrey(arrey);


void PrintArrey(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] == 0)
            {
                Console.Write("{0,-4}",String.Empty);
            }
            else Console.Write("{0,-4}",arr[i, j]);
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}