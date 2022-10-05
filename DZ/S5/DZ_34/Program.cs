// Задача 34. Задайте массив заполненый положительными трехзначными числами.
//Напишите программу, которая покажет количество четных чисел в массиве.**
//[345, 897, 568, 234] → 2**


Console.Clear();
int n = new Random().Next(10,16);
int[] arrey = new int[n];
FillArrey(arrey);
PrintArrey();
Console.Write($"-> {ChetArrey(arrey)}");


void FillArrey(int[] arr)    // Метод создания массива (n) элементов, и заполенения ПСЧ [100, 999]
{
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(100, 1000);
    }
}

int ChetArrey(int[] arr)    // Метод поиска и подсчета количества четных чисел
{
    int s = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] %2 == 0) s++;
    }
    return s;
}

void PrintArrey()           // Метод вывода значений элементов массива на экран
{
    Console.Write($"[");
    for(int i = 0; i < arrey.Length; i++)
    {
        Console.Write($"{arrey[i]},");
    }
    Console.Write($"] ");
}

