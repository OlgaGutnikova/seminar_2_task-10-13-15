// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

//Функция ввода данных
int getUserValue(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

// Функция вывода третьей цифры трехзначного числа
int third(int с)
{
    int result = с % 10;
    return result;
}

int number = getUserValue("Введите число: ");
int amount = number.ToString().Length;

if (amount > 3)
{
    while (amount > 3)
    {
        number = number / 10;
        amount = number.ToString().Length;
    }
    Console.Write($"Третьей цифрой введенного числа является цифра {third(number)}");
}

else if (amount > 2 && amount == 3)
{
    Console.Write($"Третьей цифрой введенного числа является цифра {third(number)}");
}
else
{
    Console.Write("Третьей цифры нет");
}