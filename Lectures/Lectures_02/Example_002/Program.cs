// Создаем массивы
//arrey [0] = 5;   // запись значения в массив (значение "5" в индекс "0")
//Console.WriteLine(arrey[0]); // вывод на экран элемента массива с индексом "4"

Console.Clear();
int Max(int arg1, int arg2, int arg3)
{
    int res = arg1;
    if(arg2 > res) res = arg2;
    if(arg3 > res) res = arg3;
    return res;
}
//      имя     0  1   2    3    4   5    6    7  8
int[] arrey = {23, 18, 85, 243, 186, 65, 263, -3, 97}; // создание массива
int max = Max(Max(arrey[0], arrey[1], arrey[2]),
Max(arrey[3], arrey[4], arrey[5]),
Max(arrey[6], arrey[7], arrey[8]));
Console.WriteLine(max);