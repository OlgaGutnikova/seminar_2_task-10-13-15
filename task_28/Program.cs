// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
//4 -> 24 
//5 -> 120

int getUserData(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine(message);
    Console.ResetColor();
    int userData = int.Parse(Console.ReadLine()!);
    return userData;
}

int getProizvedenie(int end)
{
    int Proizvedenie = 1;
    for (int i = 1; i <= end; i++)
    {
        Proizvedenie = Proizvedenie * i;
    }
    return Proizvedenie;
}
void showData(string messageStart, int data)
{
    Console.Write(messageStart);
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.Write(data);
    Console.ResetColor();
}
int end = getUserData("Введите число А для получения произведения");
int Proizvedenie = getProizvedenie(end);
Console.Write(Proizvedenie);