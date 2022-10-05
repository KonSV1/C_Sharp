// Находим максимум класическим перебором и с помощью функций (методов)
//создадим метод поиска max значения из трех чисел
int Max(int arg1, int arg2, int arg3) // начало метода
{
    int res = arg1;
    if(arg2 > res) res = arg2;
    if(arg3 > res) res = arg3;
    return res;
}                                     // конец метода
Console.Clear();
int a1 = 23;
int b1 = 18;
int c1 = 85;
int a2 = 243;
int b2 = 186;
int c2 = 65;
int a3 = 263;
int b3 = -3;
int c3 = 97;
int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3)); // используем метод внутри метода
Console.WriteLine(max);
