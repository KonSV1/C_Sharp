// найти элемент массива из N элементов соответсвующий значению find

Console.Clear();
//      имя     0  1   2    3    4   5    6    7 
int[] arrey = {23, 18, 85, 243, 186, 65, 18, 263, -3, 18}; // создание массива
int n = arrey.Length;
// Console.WriteLine(n);
int find = 243;
int index = 0;
while (index < n)
{
    if(arrey[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++; //index = index + 1
}