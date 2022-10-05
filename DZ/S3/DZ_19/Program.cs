// Задача 19.
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
Console.Clear();
Console.WriteLine("Введите пятизначное число");
int num = Convert.ToInt32(Console.ReadLine());
if((num / 10000 < 1) || (num / 10000 > 9)) Console.WriteLine("Введеное число не пятизначное. Попробуй еще раз.");
else
{
    int[] arrey = new int[5];                       // Создание массива
    int z = 10000;
    int num1 = num;
    for(int i = 0; i < 5; i++)
    {
        arrey[i] = num / z;                         // заполнение массива      
        num = num % z;
        z = z / 10;
        //Console.Write($"{arrey[i]} ");            // проверка заполнения массива
    }
    if((arrey[0] == arrey[4]) & (arrey[1] == arrey[3]))
    {
        Console.Write($"{num1} -> да");
    }
    else
    {
        Console.Write($"{num1} -> нет");
    }
}

