// Задача 39.
// Напишите программу которая перевернет одномерный массив
//(т.е меняет местами первый и последний элементы, второй и предпоследний и т.п)

Console.Clear();
int n = new Random().Next(5,10);
int[] arrey = new int[n];
int[] arrey1 = new int[n];
FillArrey();
MirrorArrey();
PrintResult();



void FillArrey()    // Метод заполенения массива емкостью (n) элементов ПСЧ [0, 9]
{
    for(int i = 0; i < n; i++)
    {
        arrey[i] = new Random().Next(0, 10);
    }
}

void MirrorArrey()      // метод перестановки элементов массива
{
    for (int i = 0; i < n; i++)
    {
        arrey1[n -1 - i] = arrey[i];
    }
}

void PrintResult()  // Метод вывода результата на экран
{
    Console.Write($"[ ");
    for(int i = 0; i < n-1; i++)
    {
        Console.Write($"{arrey[i]}, ");
    }
    Console.Write($"{arrey[n-1]}] -> [");
    for(int i = 0; i < n-1; i++)
    {
        Console.Write($"{arrey1[i]}, ");
    }
    Console.Write($"{arrey1[n-1]}]");
}