// Задача 45
//Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

Console.Clear();
int n = new Random().Next(5, 9);
int[] arrey = new int[n];
int[] arrey1 = new int[arrey.Length];
FillArrey(arrey);
CopyArrey();
PrintResult();


void CopyArrey()
{
    for(int i = 0; i < arrey.Length; i++)
    {
        arrey1[i] = arrey[i];
    }
}


void FillArrey(int[] arr) // Метод заполенения массива ПСЧ [0,99]
{
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 100);
    }
}

void PrintResult() // Метод вывода элементов оригинального массива и его копии
{
    Console.Write($"[");
    for(int i = 0; i < arrey.Length; i++)
    {
        Console.Write($"{arrey[i]},");
    }
    Console.WriteLine($"] - Оригинальный массив");
    Console.Write($"[");
    for(int i = 0; i < arrey.Length; i++)
    {
        Console.Write($"{arrey1[i]},");
    }
    Console.Write($"] - Копия массива");
}