//Задача 16.
//Напишите программу, которая будет принимать на вход два числа и выводить, является ли одно из них квадратом другого
//5, 25 -> Да
//16, 5 -> Нет

Console.Clear();
Console.Write("Введите первое число ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число ");
int num2 = Convert.ToInt32(Console.ReadLine());
if((num1 * num1 == num2) || (num2 * num2 == num1))
{
    Console.Write($"{num1}, {num2} - Да");
}
else
{
   Console.Write($"{num1}, {num2} - Нет"); 
}