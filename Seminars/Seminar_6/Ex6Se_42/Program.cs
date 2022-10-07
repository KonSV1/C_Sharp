// Задача 42
// Напишите программу, которая переводит десятичнео число в двоичное
Console.Clear();
Console.Write("Введите число ");
int a = Convert.ToInt32(Console.ReadLine());
int r = Convert.ToInt32((Math.Floor(Math.Log(a, 2) + 1))); //определяяем количество разрядов будущего двоичного числа
int a1 = a;
int[] arrey = new int[r]; // Размер массива равен количеству разрядов двоичного числа
DecToBin();
PrintArrey();


void DecToBin() // Метод конвертации 10 -> 2 и записи в массив двоичного числа
{
    for (int i = 0; i < r; i++)
    {
        arrey[r - 1 - i] = a1 % 2; // массив заполняется в обратном порядке от "R-1 -> 0"
        a1 = a1 / 2;
    }
}


void PrintArrey()
{
    Console.Write($"{a} -> [");
    for (int i = 0; i < r - 1; i++)
    {
        Console.Write($"{arrey[i]},");
    }
    Console.Write($"{arrey[r - 1]}]");
}