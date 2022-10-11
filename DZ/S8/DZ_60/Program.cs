// Сформируйте трехмерный массив из неповторяющихся двухзначных чисел.
//Напишите программу, которая будет построчно выводить массив добавляя индексы каждого элемента

Console.Clear();
int[,,] arrey = new int[2, 2, 2];
int n = 0;
int[] num = new int[arrey.GetLength(0) * arrey.GetLength(1) * arrey.GetLength(2)];
FillMonoArrey(num);
for (int i = 0; i < arrey.GetLength(0); i++)
{
    for (int j = 0; j < arrey.GetLength(1); j++)
    {
        for (int k = 0; k < arrey.GetLength(2); k++)
        {
            arrey[i, k, j] = num[n];
            Console.Write($"{arrey[i, k, j]}  index - [{i}, {k}, {j}]   ");
            n++;
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


void FillMonoArrey(int[] arr)
{
    arr[0] = new Random().Next(10, 100);
    for (int i = 1; i < arr.Length; i++)
    {
        for (int j = 0; j < i; j++)
        {
        Flag: arr[i] = new Random().Next(10, 100) + 1;
            if (arr[i] == arr[j]) goto Flag;
        }
    }
}