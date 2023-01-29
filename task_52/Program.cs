/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */


void printInColor(string data)
{
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.Write(data);
    Console.ResetColor();
}
int[,] get2DDoubleArray(int rowLength, int colLength, int start, int finish)
{
    int[,] array = new int[rowLength, colLength];
    for (int i = 0; i < rowLength; i++)
    {
        for (int j = 0; j < colLength; j++)
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

// Метод определения среднего арифметического элементов столбцов
double[] forwardArithmetic(int[,] array)
{
    double[] forArif = new double[array.GetLength(1)];
    double[] sum = new double[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum[j] += array[i, j];
        }
        forArif[j] = Math.Round(sum[j] / array.GetLength(0), 2);
    }
    return forArif;
}

void printforwardArithmetic(double[] forArif)
{
    Console.Write("Среднее арифметическое каждого столбца равно: ");
    for (int i = 0; i < forArif.Length; i++)
    {
        Console.Write(forArif[i] + "; ");
    }
}


int colLength = new Random().Next(2, 5);
int rowLength = new Random().Next(2, 5);
int[,] Array = get2DDoubleArray(colLength, rowLength, 0, 50);
print2Darray(Array);

double[] ForArifmetic = forwardArithmetic(Array);
printforwardArithmetic(ForArifmetic);