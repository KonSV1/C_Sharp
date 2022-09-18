// Задача 13 Напишите программу, которая сообщает третью цифру
//заданного числа или сообщает, что ее нет.

//Console.Clear();
Console.Write("Введите число  ");
int num = Convert.ToInt32(Console.ReadLine());
if((num > 99) & (num < 1000))
{
    int num1 = num % 10;
    Console.Write($"{num} -> {num1}");
}
else
{
    Console.Write("Введенное число не содержит третей цифры"); 
}