using System;

class Program
{
    public static void Main()
    {
        string surname, name, patronymic;
        name = Console.ReadLine();
        surname = Console.ReadLine();
        patronymic = Console.ReadLine();
        Console.WriteLine($"Фамилия:    {surname}");
        Console.WriteLine($"Имя:        {name}");
        Console.WriteLine($"Отчество:   {patronymic}");
    }
}
