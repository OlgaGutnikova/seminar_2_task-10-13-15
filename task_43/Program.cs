// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
//y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9-> (-0, 5; -0,5)

int getUserNumber(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}
double[] intersectionPoint(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    double[] result = new double[] { x, y };
    return result;
}
void printArray(double[] array)
{
    Console.Write("(");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write("; ");
        }
    }
    Console.WriteLine(")");
}
double B1 = getUserNumber("Введите b1: ");
double K1 = getUserNumber("Введите k1: ");
double B2 = getUserNumber("Введите b2: ");
double K2 = getUserNumber("Введите k2: ");
double[] point = intersectionPoint(B1, K1, B2, K2);
printArray(point);

