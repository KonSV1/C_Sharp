// - **Задача 35. Задайте одномерный массив из 123 случайных чисел. 
//Найдите количество элементов, значения которых лежат в отрезке [10, 99]**
// Вывод результата в виде "[Элементы массива] → количество элементов [10, 99]"

Console.Clear();
int n = 123;
int[] arrey = new int[n];
FillArrey();
PrintArrey();


void FillArrey()    // Метод создания массива (n) элементов, и заполенения ПСЧ [0, 1000]
{
    for(int i = 0; i < arrey.Length; i++)
    {
        arrey[i] = new Random().Next(0, 1000);
    }
}

int SerchNum()      // Метод поиска в массиве чисел в диапазоне [10,99] и подсчета их количества
{
    int s = 0;
    for(int i = 0; i < arrey.Length; i++)
    {
        if(arrey[i] > 9 && arrey[i] < 100)
        {
            s++;
        }
    }
    return s;
}

void PrintArrey()   //метод вывода на экран результата
{
    Console.Write($"[");
    for(int j = 0; j < arrey.Length; j++)
    {
        Console.Write($"{arrey[j]},");
    }
    Console.Write($"] -> {SerchNum()}");
}