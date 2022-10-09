// // Задача 57: Составить частотный словарь элементов двумерного массива. 
//Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// Набор данных
// Частотный массив
// { 1, 9, 9, 0, 2, 8, 0, 9 }
// 0 встречается 2 раза 
// 1 встречается 1 раз 
// 2 встречается 1 раз 
// 8 встречается 1 раз 
// 9 встречается 3 раза
// 1, 2, 3 
// 4, 6, 1 
// 2, 1, 6
// 1 встречается 3 раза 
// 2 встречается 2 раз 
// 3 встречается 1 раз 
// 4 встречается 1 раз 


Console.Clear();
Console.Write("Введите количество строк в массиве ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] arrey = new int[m, n];
int[] arrey1 = new int[m * n];
FillArrey();
PrintArrey(arrey);
FriclArrey();
PrintArreyYno();
PrintResult();





void FriclArrey()
{
    int k = 0;
    for (int i = 0; i < arrey.GetLength(0); i++)
    {
        for (int j = 0; j < arrey.GetLength(1); j++)
        {
            arrey1[k] = arrey[i,j];
            k++;
        }
    }
}

void FillArrey()
{
    for (int i = 0; i < arrey.GetLength(0); i++)
    {
        for (int j = 0; j < arrey.GetLength(1); j++)
        {
            arrey[i, j] = new Random().Next(0, 10);
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

void PrintArreyYno()
{
    for (int i = 0; i < arrey1.Length; i++)
    Console.Write("{0,-4}", arrey1[i]);
    Console.WriteLine();
}



void PrintResult()
{
    for (int i = 0; i < 10; i++)
    {
        int count = 0;
        for (int j = 0; j < arrey1.Length; j++)
        {
            if (arrey1[j] == i)
            count++;
        }
        Console.WriteLine($"{i} встречается {count} раз");
    }
}