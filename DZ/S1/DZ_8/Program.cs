// Задача 8.
//Запросить число N  и вывести на экран все четные числа от 1 до N
Console.Clear();
Console.Write("Введите положительно число больше 1 ");
int num = Convert.ToInt32(Console.ReadLine());
if(num <= 0) Console.WriteLine("Вы ввели отрицательное число, попробуйте снова");
if(num == 1) Console.WriteLine("Вы ввели 1, попробуйте снова");
int sch = 2;
while(sch <= num)
{
    Console.Write(sch);
    Console.Write(",");
    sch = sch + 2;
}

