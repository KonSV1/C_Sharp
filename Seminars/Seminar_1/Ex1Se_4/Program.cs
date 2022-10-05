//Запрос ввода трехзначного числа вывод на экран последней цифры этого числа.

Console.Clear();
Console.Write("Введите трехзначное число ");
int num = Convert.ToInt32(Console.ReadLine());
if((num > 99) & (num < 1000))
{
    int znak3 = num % 10;
    Console.Write(znak3);
}
else
{
    Console.WriteLine("Введено неверное число. Попробуй еще раз.");
}
   