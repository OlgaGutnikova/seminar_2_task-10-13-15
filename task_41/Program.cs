// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
int getUserNumber(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

int[] enterArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        Console.WriteLine($"Введите {i + 1}-й элемент массива: ");
        array[i] = int.Parse(Console.ReadLine());
    }
    return array;
}
void printArray(int[] array)
{
    Console.Write("Введены элементы: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write("  ");
        }
    }
    Console.WriteLine("");
}
int sumPositiv(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            sum = sum + array[i];
        }
    }
    return sum;
}


int M = getUserNumber("Введите количество элементов: ");
int[] Array = enterArray(M);
printArray(Array);
int Sum = sumPositiv(Array);
Console.WriteLine($"Сумма положительных элементов равна: {Sum}");
