// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
//Функция ввода данных
int getUserNumber(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}
//Функция создания массива вещественных чисел
double[] generateArray(int length)
{
    double[] result = new double[length];
    for (int i = 0; i < length; i++)
    {
        result[i] = Math.Round((new Random().NextDouble() * 100), 2);
    }
    return result;
}
//Функция печати массива
void printArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write("  ");
        }
    }
    Console.WriteLine("]");
}

// Функция нахождения разницы максимального и минимального элементов массива
double minMax(double[] array)
{
    double min = array[0];
    double max = array[0];
    double difference = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
        else
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }
        difference = max - min;
    }
    return difference;
}

int length = getUserNumber("Введите длину массива: ");
double[] Array = generateArray(length);
printArray(Array);
double Difference = minMax(Array);
Console.WriteLine(Difference);
