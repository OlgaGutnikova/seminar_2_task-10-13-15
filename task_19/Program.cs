// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

//Функция ввода данных
int getUserValue(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

int number = getUserValue("Введите пятизначное число: ");
int amount = number.ToString().Length;

if (amount > 5)
{
    Console.WriteLine("Введено некорректное число");
}
else
{
    int firstNumber = number / 10000;
    int lastNumber = number % 10;
    if (firstNumber == lastNumber)
    {
        int secondNumber = (number / 1000) % 10;
        int fourthNumber = (number / 10) % 10;
        if (secondNumber == fourthNumber)
        {
            Console.Write("Число является полиндромом");
        }
        else
        {
            Console.Write("Число не является полиндромом");
        }
    }
    else
    {
        Console.Write("Число не является полиндромом");
    }
}