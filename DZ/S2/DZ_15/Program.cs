// Задача 15.
//Напишите программу которая принемает на входе цифру
//обозначающую день недели и проверяет, является ли этот день выходным.

Console.Clear();
Console.Write("Введите число от 1 до 7  ");
int num = Convert.ToInt32(Console.ReadLine());
if ((num > 0) & (num < 8))
{
    if ((num == 6) || (num == 7))
    {
        Console.Write($"{num} -> Да");
    }
    else
    {
        Console.Write($"{num} -> Нет");
    }
}
else
{
    Console.WriteLine("Введенное число не отвечает требованиям");
    Console.Write("Число должно быть в диапазоне от 1 до 7. Попробуй еще раз.");
}