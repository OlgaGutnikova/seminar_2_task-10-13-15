// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

//Функция ввода данных
int getUserData(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

// Функция возведения в степень
int degree(int A, int B)
{
    int InDegree = A;
    for (int N = 2; N <= B; N++)
    {
        InDegree = InDegree * A;
    }
    return InDegree;
}
int NumberA = getUserData("Введите число А: ");
int NumberB = getUserData("Введите степень B: ");
int NumberInDegree = degree(NumberA, NumberB);
Console.WriteLine($"Результат {NumberInDegree}");