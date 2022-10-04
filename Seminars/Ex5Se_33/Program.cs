//Задача 33. Задайте массив. Напишите программу, которая определяет, присутсвует ли заданное число в массиве
//4; массив [ 6,5,8,2] → нет
// -3; массив [5, -8, -3, 6] → да



Console.Clear();
int n = new Random().Next(5, 10);
int[] arrey = new int[n];
FillArrey();
Console.Write("Введите число для поиска в массиве. Число должно быть в диапазоне от -9 до 9  ");
int num = Convert.ToInt32(Console.ReadLine());
PrintArrey();

void FillArrey()  //метод создания массива (5-9) элементов, и заполенения ПСЧ (-9, 9)
{
    for(int i = 0; i < arrey.Length; i++)
    {
        arrey[i] = new Random().Next(-9, 10);
    }
}

string SerchArrey() //Метод поиска числа и пор результату возвращение значения "да " или "нет" 
{
    string r = "";
    for(int i = 0; i < arrey.Length; i++)
    {
        if (arrey[i] == num) return r = "Да";
    }
    return r = "Нет";
}

void PrintArrey()   //метод вывода на экран результата
{
    Console.Write($"{num}; массив [");
    for(int j = 0; j < arrey.Length; j++)
    {
        Console.Write($"{arrey[j]},");
    }
    Console.Write($"] -> {SerchArrey()}");
}





 
