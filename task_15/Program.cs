// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

//Функция ввода данных
int getUserValue(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

int day = getUserValue("Введите день недели в виде числа от 1 до 7: ");
if (day < 1 || day > 7)
{
    Console.WriteLine("Такого дня нет");
}
else if (day > 5)
{
    Console.Write("Это выходной");
}
else
{
    Console.Write("Это будний день");
}
