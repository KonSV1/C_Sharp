//**Задача 36. Задайте одномерный массив заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечетных позициях**
// [3, 7, 23, 12] → 19


Console.Clear();
int n = new Random().Next(5, 9);
int[] arrey = new int[n];
FillArrey(arrey);
PrintArrey(arrey);
Console.Write($" -> {SummNech(arrey)}");




void FillArrey(int[] arr) // Метод создания массива (n) элементов, и заполенения ПСЧ [0,99]
{
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 100);
    }
}

void PrintArrey(int[] arr) // Метод вывода значений элементов массива на экран
{
    Console.Write($"[");
    for(int i = 0; i < arrey.Length; i++)
    {
        Console.Write($"{arrey[i]},");
    }
    Console.Write($"] ");
}

int SummNech(int[] arr) // Метод подсчета суммы элементов массива на нечетных позициях
{
    int s = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i%2 == 0)
        {
            s = s + arr[i];
        }
    }
    return s;
}