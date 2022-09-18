// Определить день недели по цифре от 1 до 7

Console.Clear();
Console.Write("Введите число от 1 до 7 ");
int num = Convert.ToInt32(Console.ReadLine());
if(num > 7) Console.WriteLine("Нет такого дня недели, попробуй снова");
if(num == 1) Console.WriteLine("Понедельник");
if(num == 2) Console.WriteLine("Вторник");
if(num == 3) Console.WriteLine("Среда");
if(num == 4) Console.WriteLine("Четверг");
if(num == 5) Console.WriteLine("Пятница");
if(num == 6) Console.WriteLine("Суббота");
if(num == 7) Console.WriteLine("Воскресенье");


