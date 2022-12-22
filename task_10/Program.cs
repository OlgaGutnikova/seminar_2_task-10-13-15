// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

//Функция ввода данных
int getUserValue(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

// Функция вывода второй цифры трехзначного числа
int secondX(int b)
{
    int result = (b % 100) / 10;
    return result;
}

int number = getUserValue("Введите трехзначное число: ");
int amount = number.ToString().Length;

if (amount > 3 || amount < 3)
{
    Console.WriteLine("Введено некорректное число");
}
else
{
    Console.Write($"Второй цифрой числа {number} является цифра {secondX(number)}");
}

