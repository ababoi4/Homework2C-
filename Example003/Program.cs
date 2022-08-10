// Задача 3: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


int Prompt(string message)
{
    System.Console.Write(message);
    string readVelue = Console.ReadLine();
    int result = int.Parse(readVelue);
    return result;
}

int userNum = Prompt("Введите число ->");
int userNum1 = userNum % 10;
if(userNum > 99) 
{
    System.Console.WriteLine($"{userNum1}");
}
else 
{
    System.Console.WriteLine($"Третьей цыфры нет");
}