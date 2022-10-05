// Задача 41
//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Clear();
Console.Write("Сколько чисел желаете ввести? ");
int m = Convert.ToInt32(Console.ReadLine());
double[] arrey = new double[m];
int a = 0;
for (int i = 0; i < m; i++)
{
    Console.Clear();
    Console.Write($"Введите число № {i + 1}  ");
    arrey[i] = Convert.ToDouble(Console.ReadLine());
    if (arrey[i] > 0) a++;
}
Console.Clear();
PrintArrey(arrey);







void PrintArrey(double[] arr) // Метод вывода результата
{
    for(int i = 0; i < m - 1; i++)
    {
        Console.Write($"{arrey[i]}, ");
    }
    Console.Write($"{arrey[m-1]} -> {a} ");
}