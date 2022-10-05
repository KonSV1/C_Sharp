// Цикл for
// на примере метода 4-го вида

string Metod4(int count, string c)        
{                           
    string result = string.Empty;           
    for(int i = 0; i < count; i++)
    {
        result = result + c;
    }
    return result;                           
}
  string res = Metod4(10, "qwert ");        
  Console.WriteLine(res); 

// Цикл в цикле
// на примере таблицы умножения

  for(int i = 2; i <= 10; i++)
  {
    for(int j = 1; j <= 10; j++)
    {
        Console.WriteLine($"{i} * {j} = {i*j}");
    }
    Console.WriteLine();
  }