//**Задача 38. Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементами массива.**
//[3, 7, 22, 2, 78] → 76

//Console.Clear();
int n = new Random().Next(5, 9);
double[] arrey = new double[n];
FillArrey(arrey);
PrintArrey(arrey);
Console.Write($" -> {Math.Round(RaznArrey(arrey), 2)}");




void FillArrey(double[] arr) // Метод создания массива (n) элементов, и заполенения ПСВЧ [0,99]
{
    for(int i = 0; i < arr.Length; i++)
    {
        double v1 = new Random().Next(0, 100);
        double v2 = new Random().Next(1, 10);
        arr[i] = Math.Round((v1 / v2), 2);
    }
}

void PrintArrey(double[] arr) // Метод вывода значений элементов массива на экран
{
    Console.Write($"[ ");
    for(int i = 0; i < arrey.Length; i++)
    {
        Console.Write($"{arrey[i]}; ");
    }
    Console.Write($"] ");
}

double RaznArrey(double[] arr) // Метод поиска макс и мин значений и вычисления разницы
{
    double max = arr[0];
    double min = arr[0];
    double res = 0;
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
        if (arr[i] < min) min = arr[i];
    }
    return res = max - min;
}