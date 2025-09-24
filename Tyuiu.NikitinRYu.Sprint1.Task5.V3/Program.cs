using Tyuiu.NikitinRYu.Sprint1.Task5.V3.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #1 | Выполнил: Никитин Р.Ю. | ИБКСб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #1                                                               *");
Console.WriteLine("* Тема: Преобразование типов и класс Convert                              *");
Console.WriteLine("* Задание #5                                                              *");
Console.WriteLine("* Вариант #3                                                              *");
Console.WriteLine("* Выполнил: Никитин Роман Юрьевич     | ИБКСб-25-1                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая присваивает целой переменной h третью от    *");
Console.WriteLine("* конца цифру в записи положительного целого числа k                      *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

Console.Write("Введите положительное целое число k: ");
string input = Console.ReadLine();

if (!int.TryParse(input, out int k) || k <= 0)
{
    Console.WriteLine("Ошибка: введите положительное целое число!");
    Console.ReadKey();
    return;
}

int h = ds.Calculate(k);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine($"Третья с конца цифра числа {k} равна {h}");

Console.ReadKey();
