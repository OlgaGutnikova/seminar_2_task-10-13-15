/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/

uint getFromUserData(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine(message);
    Console.ResetColor();
    uint result = uint.Parse(Console.ReadLine()!);
    return result;
}

uint Accerman(uint m, uint n)
{
    if (m == 0)
        return n + 1;
    else
      if ((m != 0) && (n == 0))
        return Accerman(m - 1, 1);
    else
        return Accerman(m - 1, Accerman(m, n - 1));
}
uint M = getFromUserData("Введите значение M");
uint N = getFromUserData("Введите значение N");
uint A = Accerman(M, N);
Console.WriteLine($"Функция Аккермана А(m,n)={A}");

// функция Аккермана
