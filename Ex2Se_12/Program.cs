// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
//34, 5 -> не кратно, остаток 4 
//16, 4 -> кратно

Console.Clear();
Console.Write("Введите первое число ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число ");
int num2 = Convert.ToInt32(Console.ReadLine());
int num3 = 0;
if(num1 > num2) Console.WriteLine("Второе число должно быть больше первого. Попробуй еще раз");
else
{
num3 = num2 % num1;
    if(num3 == 0) Console.WriteLine($"Число {num2} кратно числу {num1}");
    if (num3 > 0) Console.WriteLine($"Число {num2}  не кратно числу {num1}, остаток от деления равен {num3}");
}
    


