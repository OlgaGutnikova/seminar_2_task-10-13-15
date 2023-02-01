/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

int getFromUserData(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine(message);
    Console.ResetColor();
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

int sumElements(int m, int n)
{
    if (m == n)
    {
        return m;
    }
    return m + sumElements(m + 1, n);
}
int userNumberStart = getFromUserData("Введите значение M");
int userNumberFinish = getFromUserData("Введите значение N");
int start = Math.Min(userNumberStart, userNumberFinish);
int finish = Math.Max(userNumberStart, userNumberFinish);
int rage = sumElements(start, finish);
Console.WriteLine($"Сумма элементов от M до N равна: {rage}");