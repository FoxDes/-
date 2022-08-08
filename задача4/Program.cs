Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "Фиафан")
{
    Console.WriteLine("Фига какая встреча!");
}
else
{
    Console.Write("Здаровки, ");
    Console.WriteLine(username);
}