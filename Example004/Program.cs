// Задача 4: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

int Prompt(string message)
{
    System.Console.Write(message);
    string readVelue = Console.ReadLine();
    int result = int.Parse(readVelue);
    return result;
}

int dayNumber = Prompt("Введите число от 1 до 7 ->");
if (dayNumber == 6 || dayNumber == 7)
{
    System.Console.WriteLine("Этот день выходной");
}
else if (dayNumber < 1 || dayNumber > 7)
{
    Console.WriteLine("это вообще не день недели");
}
else 
{
    System.Console.WriteLine("Этот день не выходной");
}