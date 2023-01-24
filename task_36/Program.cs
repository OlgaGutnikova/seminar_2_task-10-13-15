// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


//Функция создания массива
int[] generateArray(int length)
{
    int[] result = new int[length];
    for (int i = 0; i < length; i++)
    {
        result[i] = new Random().Next(100);
    }
    return result;
}
//Функция ввода данных
int getUserNumber(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

//Функция печати массива
void printArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}
//Функция нахождения суммы еэлементов массива, стоящих на нечетных позициях
int oddIndex(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 > 0)
        {
            sum = sum + array[i];
        }
    }
    return sum;
}
int length = getUserNumber("Введите длину массива: ");
int[] Array = generateArray(length);
printArray(Array);
int sumOddIndexNumbers = oddIndex(Array);
Console.WriteLine($"Сумма чисел, стоящих на нечетных позициях массива равна: {sumOddIndexNumbers}");