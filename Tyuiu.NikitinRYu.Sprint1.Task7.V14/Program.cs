using Tyuiu.NikitinRYu.Sprint1.Task7.V14.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #1 | Выполнил: Никитин Р.Ю. | ИБКСб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #1                                                               *");
Console.WriteLine("* Тема: Class Math                                                        *");
Console.WriteLine("* Задание #4                                                              *");
Console.WriteLine("* Вариант #10                                                             *");
Console.WriteLine("* Выполнил: Никитин Роман Юрьевич     | ИБКСб-25-1                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

Console.Write("Введите x: ");
double x = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите y: ");
double y = Convert.ToDouble(Console.ReadLine());

Console.WriteLine();
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

double result = ds.Calculate(x, y);

Console.WriteLine($"z = {result}");
Console.ReadKey();
        
