// Задача 13/
//Напишите программу, которая сообщает третью цифру
//заданного числа или сообщает, что ее нет.

//Console.Clear();
Console.Write("Введите число  ");
int num = Convert.ToInt32(Console.ReadLine());
int num1 = num;
int num2;
if(num > 99)
{
    if (num > 1000)
    {
       while (num > 1000)
        {
            num = num / 10;
        }   
    }
    num2 = num % 10;
    Console.Write($"{num1} -> {num2}");
}
else
{
   Console.Write("Введенное число не содержит третей цифры");
}
