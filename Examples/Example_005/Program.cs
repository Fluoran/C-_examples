
System.Console.WriteLine("Введите имя пользователя");
string username = Console.ReadLine();
if (username.ToLower() == "максим")
{
    System.Console.WriteLine("Ура, это же Максим!");
}
else
{
    System.Console.WriteLine("Привет, ");
    System.Console.WriteLine(username);
}
