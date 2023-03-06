// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


Console.WriteLine("Введите число [,]");
string strSource = Console.ReadLine()!;

if (string.IsNullOrEmpty(strSource)) strSource = GenNumber();

string GenNumber()
{
    for (int i = 0; i < new Random().Next(5, 20); i++)
    {
        strSource = strSource + Convert.ToString(new Random().Next(-100, 101) + ",");
    }
    strSource = strSource + Convert.ToString(new Random().Next(-10, 11));
    return strSource;
}
int PositiveNumber(string strSource)
{
    string[] result = strSource.Split(",");
    int count = 0;
    for (int i = 0; i < result.Length; i++)
    {
        try
        {
            if (Convert.ToInt32(result[i]) > 0) count++;    
        }
        catch (System.Exception)
        {
            Console.WriteLine("");
            Environment.Exit(0);
        }

    }
    return count;
}

Console.WriteLine($"Исходная строка цифр => {strSource}");
int count = PositiveNumber(strSource);
Console.WriteLine($"Кол-во положительных чисел больше 0 => {count}");