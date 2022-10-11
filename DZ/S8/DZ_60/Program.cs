// Сформируйте трехмерный массив из неповторяющихся двухзначных чисел.
//Напишите программу, которая будет построчно выводить массив добавляя индексы каждого элемента

//Console.Clear();
int[,,] arrey = new int[4, 4, 5];
int n = 0;
int[] num = new int[arrey.GetLength(0) * arrey.GetLength(1) * arrey.GetLength(2)];
FillMonoArrey(num);
for (int i = 0; i < arrey.GetLength(0); i++)
{
    for (int j = 0; j < arrey.GetLength(1); j++)
    {
        for (int k = 0; k < arrey.GetLength(2); k++)
        {
            arrey[i, j, k] = num[n];
            Console.Write($"{arrey[i, j, k]}  index - [{i}, {j}, {k}]   ");
            n++;
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


void FillMonoArrey(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(10, 100);
        for (int j = 0; j <= i; j++)
        {
            if(arr[i] == arr[j]) arr[i] = new Random().Next(10, 100);
        }
    }
}
