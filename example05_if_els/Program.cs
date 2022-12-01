// Console.WriteLine("Введите имя пользователя: ");
// string username = Console.ReadLine();

// if (username == "Маша") // есть проблемы, если ввести имя с маленькой буквы или любую последующую большими
// {
//     Console.WriteLine("Ура, это же Маша!");
// }
// else
// {
//     Console.Write("Привет, ");
//     Console.WriteLine(username + "!");
// }

// исправил недочёт
Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "маша") // ToLower() - все символы строки переводит в нижний регистр
{
    Console.WriteLine("Ура, это же Маша!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username + "!");
}