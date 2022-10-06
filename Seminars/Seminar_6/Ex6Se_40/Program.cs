//Задача 40
//Напишите программу, которая принимет на вход три числа и проверяет может ли существовать треугольник со сторонами такой длины

Console.Clear();
Console.WriteLine("Введите первое число ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число ");
int c = Convert.ToInt32(Console.ReadLine());
if ((a < b + c) && (b < c + a) && (c < a + b))
{
    Console.WriteLine("Треугольник с такими сторонами существует");
}
else
{
    Console.WriteLine("Треугольника с такими сторонами не существует");
}