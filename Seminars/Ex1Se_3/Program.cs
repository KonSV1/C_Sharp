// Запросить число "N", вывести на экра все целые числа от "-N" до "N"
Console.Clear();
Console.Write("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());
int count;
if (num > 0) count = -num;
else
{
    count = num;
    num = -num;
}
    while (count <= num)
    {
        Console.Write($"{count}, ");
        count += 1;
    }