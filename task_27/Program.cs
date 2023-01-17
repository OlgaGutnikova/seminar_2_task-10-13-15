// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Функция ввода данных
int getUserData(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

//Функция сложения цифр заданного числа

int CountNumber(int c)
{
    int length = c.ToString().Length;
    int sum = 0;

    for (int i = 0; i < length; i++)
    {
        int n = c % 10;
        c = c / 10;
        sum = sum + n;
    }
    sum = sum + c;
    return sum;
}

int Number = getUserData("Введите число: ");
int Sum = CountNumber(Number);
Console.WriteLine($"Сумма цифр числа {Number} равна {Sum}");