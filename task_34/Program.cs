// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

//Функция ввода данных
int getUserNumber(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}
//Функция создания массива
int[] generateArray(int length)
{
    int[] result = new int[length];
    for (int i = 0; i < length; i++)
    {
        result[i] = new Random().Next(100, 1000);
    }
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
//Функция проверки четности элементов массива
int evenNumber(int[] array)
{
    int index = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            index++;
        }
    }
    return index;
}

int number = getUserNumber("Введите длину массива: ");
int[] Array = generateArray(number);
printArray(Array);
int count = evenNumber(Array);
if (count > 0)
{
    Console.WriteLine($"Количество четных чисел в массиве равно: {count}");
}
