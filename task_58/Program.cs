/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/


int GetDataFromUser(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    System.Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);
    Console.ResetColor();
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
int[,] MultiplyMatrix(int[,] MatrixA, int[,] MatrixB)
{
    int[,] MatrixResult = new int[MatrixA.GetLength(0), MatrixB.GetLength(1)];
    for (int i = 0; i < MatrixResult.GetLength(0); i++)
    {
        for (int j = 0; j < MatrixResult.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < MatrixA.GetLength(1); k++)
            {
                sum += MatrixA[i, k] * MatrixB[k, j];
            }
            MatrixResult[i, j] = sum;
        }
    }
    return MatrixResult;
}

int m = GetDataFromUser("Введите количество строк 1-й матрицы: ");
int n = GetDataFromUser("Введите количество столбцов 1-й матрицы (равно количеству строк 2-й матрицы:");
int p = GetDataFromUser("Введите количество столбцов 2-й матрицы: ");
int[,] arrayA = get2DDoubleArray(m, n, 0, 4);
int[,] arrayB = get2DDoubleArray(n, p, 0, 4);
int[,] arrayC = MultiplyMatrix(arrayA, arrayB);
print2Darray(arrayA);
print2Darray(arrayB);
print2Darray(arrayC);
