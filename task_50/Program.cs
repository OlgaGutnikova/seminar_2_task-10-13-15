/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве и 
возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/

//Функция вывода массива случайного размера
int getUserNumber(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}
void printInColor(string data)
{
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.Write(data);
    Console.ResetColor();
}
int[,] get2DDoubleArray(int colLength, int rowLength, int start, int finish)
{
    int[,] array = new int[colLength, rowLength];
    for (int i = 0; i < colLength; i++)
    {
        for (int j = 0; j < rowLength; j++)
        {
            array[i, j] = new Random().Next(start, finish + 1);
        }
    }
    return array;
}
void print2Darray(int[,] array)
{
    Console.Write(" \t");
    for (int j = 0; j < array.GetLength(1); j++)
    {
        printInColor(j + "\t");
    }
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        printInColor(i + "\t");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int colLength = new Random().Next(3, 15);
int rowLength = new Random().Next(3, 15);
int[,] Array = get2DDoubleArray(colLength, rowLength, 0, 50);
print2Darray(Array);
int IndexI = getUserNumber("Введите индекс I: ");
int IndexJ = getUserNumber("Введите индекс J: ");
if (IndexI <= Array.GetLength(0) - 1 && IndexJ <= Array.GetLength(1) - 1)
{
    int number = Array[IndexI, IndexJ];
    Console.WriteLine($"Элемент массива с индексами ({IndexI}, {IndexJ}) равен: {number}");
}
else Console.WriteLine($"Элемента с индексами ({IndexI}, {IndexJ}) нет");


