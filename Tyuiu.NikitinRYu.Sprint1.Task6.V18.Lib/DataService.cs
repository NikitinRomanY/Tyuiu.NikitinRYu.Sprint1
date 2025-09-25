using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.NikitinRYu.Sprint1.Task6.V18.Lib
{
    public class DataService : ISprint1Task6V18
    {
        public bool CheckNumber(string value)
        {
            // Пустая строка
            if (string.IsNullOrEmpty(value))
                return false;

            // Проверяем каждый символ
            foreach (char c in value)
            {
                if (!char.IsDigit(c))
                    return false;
            }

            // Проверяем, что число не начинается с 0 (кроме "0")
            if (value[0] == '0' && value.Length > 1)
                return false;

            // Натуральное число должно быть > 0
            if (value == "0")
                return false;

            return true;
        }
    }
}
