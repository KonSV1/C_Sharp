// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
//Console.Clear();
Console.Write("Введите число A ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число B ");
int b = Convert.ToInt32(Console.ReadLine());
if(b > 0)
{
    //double c = Math.Pow(a, b);
    int c = 1;
    for(int i = 0; i < b; i++)
    {
        c = c * a;
    }
    Console.WriteLine($"{a}, {b} -> {c}");
}
else Console.WriteLine("Число В не натуральное. Попробуй еще раз.");