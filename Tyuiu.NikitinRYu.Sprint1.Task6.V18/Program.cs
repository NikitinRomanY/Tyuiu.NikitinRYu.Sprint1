using Tyuiu.NikitinRYu.Sprint1.Task6.V18.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #1 | Выполнил: Никитин Р.Ю. | ИБКСб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #1                                                               *");
Console.WriteLine("* Тема: Работа со строками класс String                                   *");
Console.WriteLine("* Задание #6                                                              *");
Console.WriteLine("* Вариант #18                                                             *");
Console.WriteLine("* Выполнил: Никитин Роман Юрьевич     | ИБКСб-25-1                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу: пользователь вводит текст. Проверить, что строка    *");
Console.WriteLine("* является символьным представлением натурального числа                   *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

Console.Write("Введите текст: ");
string input = Console.ReadLine();

bool isNatural = ds.CheckNumber(input);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

if (isNatural)
{
    Console.WriteLine($"Строка \"{input}\" является натуральным числом");
}
else
{
    Console.WriteLine($"Строка \"{input}\" НЕ является натуральным числом");
}

Console.ReadKey();