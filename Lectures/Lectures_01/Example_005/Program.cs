Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();
switch (username.ToLower())
{
    case "маша":
        Console.WriteLine("Ура, это же Маша!");
        break;
    default:
        Console.Write("Привет, ");
        Console.WriteLine(username);
        break;
}