// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int getUserValue(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine());
    return result;
}
double getDistanseCoordinate(int userAx, int userAy, int userAz, int userBx, int userBy, int userBz)
{
    double result = Math.Round((Math.Sqrt(Math.Pow((userAx - userBx), 2) + Math.Pow((userAy - userBy), 2) + Math.Pow((userAz - userBz), 2))), 2);
    return result;
}
int userAx = getUserValue("Введите X для точки А");
int userAy = getUserValue("Введите Y для точки А");
int userAz = getUserValue("Введите Z для точки А");

int userBx = getUserValue("Введите X для точки В");
int userBy = getUserValue("Введите Y для точки В");
int userBz = getUserValue("Введите Z для точки В");

double distance = getDistanseCoordinate(userAx, userAy, userAz, userBx, userBy, userBz);
Console.WriteLine($"Расстояние между точками {distance}");